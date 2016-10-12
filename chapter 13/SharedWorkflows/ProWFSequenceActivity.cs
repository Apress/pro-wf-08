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
    /// A custom composite activity that mimics a
    /// SequenceActivity
    /// </summary>
    [Designer(typeof(SequentialActivityDesigner))]
    public partial class ProWFSequenceActivity : CompositeActivity,
        IActivityEventListener<ActivityExecutionStatusChangedEventArgs>
    {
        public ProWFSequenceActivity()
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
                //register to receive the Closed event 
                this.EnabledActivities[0].RegisterForStatusChange(
                    Activity.ClosedEvent, this);
                //schedule the first activity for execution
                executionContext.ExecuteActivity(this.EnabledActivities[0]);
            }

            //signal that we are still executing
            return ActivityExecutionStatus.Executing;
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

            //determine which activity just completed
            Int32 activityIndex = this.EnabledActivities.IndexOf(e.Activity);

            //was this the last activity?
            if (activityIndex == this.EnabledActivities.Count - 1)
            {
                //signal that we are now complete, including
                //execution of all of our child activities
                context.CloseActivity();
            }
            else
            {
                //execute the next activity as long as we are still 
                //executing. don't schedule any more child activities if
                //we are in another state such as canceling. 
                activityIndex++;
                if (this.ExecutionStatus == ActivityExecutionStatus.Executing)
                {
                    //register for the Closed event and schedule execution
                    this.EnabledActivities[activityIndex].RegisterForStatusChange(
                        Activity.ClosedEvent, this);
                    context.ExecuteActivity(this.EnabledActivities[activityIndex]);
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
                    case ActivityExecutionStatus.Initialized:
                    case ActivityExecutionStatus.Closed:
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
