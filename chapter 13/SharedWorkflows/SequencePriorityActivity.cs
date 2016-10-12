//--------------------------------------------------------------------------------
// This file is part of the downloadable code for the Apress book:
// Pro WF: Windows Workflow in .NET 3.5
// Copyright (c) Bruce Bukovics.  All rights reserved.
//
// This code is provided as is without warranty of any kind, either expressed
// or implied, including but not limited to fitness for any particular purpose. 
// You may use the code for any commercial or noncommercial purpose, and combine 
// it with your own code, but cannot reproduce it in whole or in part for 
// publication purposes without prior approval. 
//--------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Activities;

namespace SharedWorkflows
{
    /// <summary>
    /// A custom composite activity that executes
    /// child activities in order based on their
    /// relative priority
    /// </summary>
    [Designer(typeof(SequencePriorityActivityDesigner))]
    public partial class SequencePriorityActivity : CompositeActivity,
        IActivityEventListener<ActivityExecutionStatusChangedEventArgs>
    {
        public static readonly DependencyProperty PriorityProperty
            = DependencyProperty.RegisterAttached("Priority",
                typeof(Int32),
                typeof(SequencePriorityActivity),
                new PropertyMetadata(DependencyPropertyOptions.Metadata));

        public static object GetPriorityProperty(object dependencyObject)
        {
            if (dependencyObject == null)
            {
                throw new ArgumentNullException("dependencyObject");
            }
            return (dependencyObject as DependencyObject).GetValue(
                PriorityProperty);
        }

        public static void SetPriorityProperty(
            object dependencyObject, object value)
        {
            if (dependencyObject == null)
            {
                throw new ArgumentNullException("dependencyObject");
            }
            (dependencyObject as DependencyObject).SetValue(
                PriorityProperty, value);
        }

        public SequencePriorityActivity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Override Execute method
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        protected override ActivityExecutionStatus Execute(
            ActivityExecutionContext executionContext)
        {
            //if we don't have any child activities to execute,
            //we signal that we are done executing
            if (this.EnabledActivities.Count == 0)
            {
                return ActivityExecutionStatus.Closed;
            }
            else
            {
                Activity nextActivity = GetNextActivity();
                if (nextActivity != null)
                {
                    //register to receive the Closed event 
                    nextActivity.RegisterForStatusChange(
                        Activity.ClosedEvent, this);
                    //schedule the first activity for execution
                    executionContext.ExecuteActivity(nextActivity);
                }
                else
                {
                    //we're done
                    return ActivityExecutionStatus.Closed;
                }
            }

            //signal that we are still executing
            return ActivityExecutionStatus.Executing;
        }

        /// <summary>
        /// Return the activity that is runnable and has the 
        /// highest priority. 
        /// </summary>
        /// <returns></returns>
        private Activity GetNextActivity()
        {
            Activity result = null;
            Int32 highestPriority = -1;
            foreach (Activity activity in this.EnabledActivities)
            {
                if (activity.ExecutionStatus == ActivityExecutionStatus.Initialized)
                {
                    Int32 priority = (Int32)activity.GetValue(PriorityProperty);
                    if (priority > highestPriority)
                    {
                        highestPriority = priority;
                        result = activity;
                    }
                }
            }
            return result;
        }

        #region IActivityEventListener Members

        /// <summary>
        /// Handle closed events from child activities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnEvent(object sender,
            ActivityExecutionStatusChangedEventArgs e)
        {
            //the sender is the ActivityExecutionContext
            ActivityExecutionContext context = sender
                as ActivityExecutionContext;
            if (context == null)
            {
                throw new ArgumentException(
                    "Expected sender to be an ActivityExecutionContext",
                    "sender");
            }

            //unregister for the Closed event of this activity
            e.Activity.UnregisterForStatusChange(
                Activity.ClosedEvent, this);

            //execute the next activity as long as we are still 
            //executing. don't schedule any more child activities if
            //we are in another state such as canceling. 
            if (this.ExecutionStatus == ActivityExecutionStatus.Executing)
            {
                Activity nextActivity = GetNextActivity();
                if (nextActivity != null)
                {
                    //register for the Closed event and schedule execution
                    nextActivity.RegisterForStatusChange(
                        Activity.ClosedEvent, this);
                    context.ExecuteActivity(nextActivity);
                }
                else
                {
                    //we're done
                    context.CloseActivity();
                }
            }
            else if (this.ExecutionStatus == ActivityExecutionStatus.Canceling)
            {
                //we are canceling, but is it time to close yet?
                if (CancelProcessing(context))
                {
                    //all child activities have completed or canceled, so
                    //we can close out this canceled activity
                    context.CloseActivity();
                }
            }
        }

        #endregion

        /// <summary>
        /// Override Cancel method
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        protected override ActivityExecutionStatus Cancel(
            ActivityExecutionContext executionContext)
        {
            //we have been told to cancel execution. Cancel
            //any child activities that are executing and determine
            //if we can close now. 
            if (CancelProcessing(executionContext))
            {
                //all child activities have ceased processing
                return ActivityExecutionStatus.Closed;
            }
            else
            {
                //we are still waiting for a child to close
                return ActivityExecutionStatus.Canceling;
            }
        }

        /// <summary>
        /// Cancel any child activities and determine if 
        /// we can close this activity 
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        private Boolean CancelProcessing(
            ActivityExecutionContext executionContext)
        {
            Boolean isTimeToClose = true;
            foreach (Activity activity in this.EnabledActivities)
            {
                if (!isTimeToClose)
                {
                    //no need to check any other activities
                    break;
                }
                switch (activity.ExecutionStatus)
                {
                    case ActivityExecutionStatus.Executing:
                        //this activity is executing, so cancel it
                        executionContext.CancelActivity(activity);
                        //we can't close until this activity closes
                        isTimeToClose = false;
                        break;
                    case ActivityExecutionStatus.Canceling:
                    case ActivityExecutionStatus.Compensating:
                    case ActivityExecutionStatus.Faulting:
                        //we can't close if any activities are 
                        //in these states
                        isTimeToClose = false;
                        break;
                    case ActivityExecutionStatus.Closed:
                        //ok to close
                        break;
                    case ActivityExecutionStatus.Initialized:
                        //ok to close
                        break;
                    default:
                        break;
                }
            }
            return isTimeToClose;
        }
    }
}
