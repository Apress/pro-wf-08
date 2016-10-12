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
using System.Workflow.Runtime;
using System.Workflow.Activities;

namespace SharedWorkflows
{
    /// <summary>
    /// A custom event-driven activity that accepts
    /// the guessing game input via a workflow queue
    /// </summary>
    public partial class ProcessGuessActivity : Activity, IEventActivity,
        IActivityEventListener<QueueEventArgs>
    {
        private readonly String _queueName = "GuessQueue";

        #region Dependency Properties

        public static DependencyProperty TheNumberProperty
            = System.Workflow.ComponentModel.DependencyProperty.Register(
            "TheNumber", typeof(Int32), typeof(ProcessGuessActivity));

        [Description("The number to guess")]
        [Category("Event Handling")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Int32 TheNumber
        {
            get
            {
                return ((Int32)(base.GetValue(ProcessGuessActivity.TheNumberProperty)));
            }
            set
            {
                base.SetValue(ProcessGuessActivity.TheNumberProperty, value);
            }
        }

        public static DependencyProperty MessageProperty
            = System.Workflow.ComponentModel.DependencyProperty.Register(
            "Message", typeof(String), typeof(ProcessGuessActivity));

        [Description("A hint message")]
        [Category("Event Handling")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String Message
        {
            get
            {
                return ((String)(base.GetValue(ProcessGuessActivity.MessageProperty)));
            }
            set
            {
                base.SetValue(ProcessGuessActivity.MessageProperty, value);
            }
        }

        public static DependencyProperty IsCompleteProperty
            = System.Workflow.ComponentModel.DependencyProperty.Register(
            "IsComplete", typeof(Boolean), typeof(ProcessGuessActivity));

        [Description("Signal that the correct guess was received")]
        [Category("Event Handling")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Boolean IsComplete
        {
            get
            {
                return ((Boolean)(base.GetValue(ProcessGuessActivity.IsCompleteProperty)));
            }
            set
            {
                base.SetValue(ProcessGuessActivity.IsCompleteProperty, value);
            }
        }

        #endregion

        public ProcessGuessActivity()
        {
            InitializeComponent();
        }

        #region Method overrides

        /// <summary>
        /// Primary execution method
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        protected override ActivityExecutionStatus Execute(
            ActivityExecutionContext executionContext)
        {
            //This should be true if we are a child of an
            //EventDrivenActivity. The EventDrivenActivity receives
            //the event and then schedules us for normal execution. 
            if (HandleQueuedMessage(executionContext))
            {
                return ActivityExecutionStatus.Closed;
            }

            //If we get here, it means we are outside
            //of an EventDrivenActivity and we must subscribe
            //to ourself to be notified when a queue message
            //arrives.  
            Subscribe(executionContext, this);
            //tell the runtime that we are still executing.
            return ActivityExecutionStatus.Executing;
        }

        protected override void Initialize(IServiceProvider provider)
        {
            base.Initialize(provider);

            //get the queuing service
            WorkflowQueuingService queueService
                = provider.GetService(typeof(WorkflowQueuingService))
                    as WorkflowQueuingService;
            if (queueService != null)
            {
                //if our queue doesn't exist, create it
                if (!queueService.Exists(_queueName))
                {
                    queueService.CreateWorkflowQueue(_queueName, true);
                }
            }
        }

        protected override void Uninitialize(IServiceProvider provider)
        {
            base.Uninitialize(provider);

            WorkflowQueuingService queueService
                = provider.GetService(typeof(WorkflowQueuingService))
                    as WorkflowQueuingService;
            if (queueService != null)
            {
                //delete our queue
                if (queueService.Exists(_queueName))
                {
                    queueService.DeleteWorkflowQueue(_queueName);
                }
            }
        }

        /// <summary>
        /// Cancel execution
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        protected override ActivityExecutionStatus Cancel(
            ActivityExecutionContext executionContext)
        {
            base.Cancel(executionContext);
            //unregister for any events when we are canceled.
            UnregisterForQueueEvents(executionContext, this);
            return ActivityExecutionStatus.Closed;
        }

        #endregion

        #region IEventActivity Members

        /// <summary>
        /// Return the queue name that must be used when 
        /// communicating with this activity
        /// </summary>
        public IComparable QueueName
        {
            get { return _queueName; }
        }

        /// <summary>
        /// Called by the parent EventDrivenActivity. Registering the
        /// parent activity for queue events enables it to be notified
        /// when a new queue message arrives.
        /// </summary>
        /// <param name="parentContext"></param>
        /// <param name="parentEventHandler"></param>
        public void Subscribe(ActivityExecutionContext parentContext,
            IActivityEventListener<QueueEventArgs> parentEventHandler)
        {
            RegisterForQueueEvents(parentContext, parentEventHandler);
        }

        /// <summary>
        /// Called by the parent EventDrivenActivity once it receives
        /// an event and before we are scheduled for execution.
        /// </summary>
        /// <param name="parentContext"></param>
        /// <param name="parentEventHandler"></param>
        public void Unsubscribe(ActivityExecutionContext parentContext,
            IActivityEventListener<QueueEventArgs> parentEventHandler)
        {
            UnregisterForQueueEvents(parentContext, parentEventHandler);
        }

        #endregion

        #region IActivityEventListener<QueueEventArgs> Members

        /// <summary>
        /// Notification that an event was received
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// This is only invoked when this activity is declared outside
        /// of an EventDrivenActivity.  If we are a child of an
        /// EventDrivenActivity, our parent's OnEvent method is
        /// executed when a queue message arrives.
        /// </remarks>
        public void OnEvent(object sender, QueueEventArgs e)
        {
            ActivityExecutionContext aec
                = sender as ActivityExecutionContext;

            //if we are still executing when we receive this event,
            //process it.
            if (this.ExecutionStatus == ActivityExecutionStatus.Executing)
            {
                if (HandleQueuedMessage(aec))
                {
                    //unregister now since registration is by aec. If we
                    //are called again it will be under a different aec.
                    UnregisterForQueueEvents(aec, this);
                    //we processed the message, so now we can
                    //tell the runtime that we're done executing
                    aec.CloseActivity();
                }
            }
        }

        #endregion

        #region Queue processing methods

        /// <summary>
        /// Register for notification when a new queue message arrives
        /// </summary>
        /// <param name="aec"></param>
        /// <param name="eventHandler"></param>
        /// <remarks>
        /// Can be used to register ourselves or our parent
        /// EventDrivenActivity
        /// </remarks>
        private void RegisterForQueueEvents(ActivityExecutionContext aec,
            IActivityEventListener<QueueEventArgs> eventHandler)
        {
            //get the queuing service
            WorkflowQueuingService queueService
                = aec.GetService<WorkflowQueuingService>();
            if (queueService != null)
            {
                if (queueService.Exists(_queueName))
                {
                    WorkflowQueue queue = queueService.GetWorkflowQueue(_queueName);
                    //register for the queue event
                    queue.RegisterForQueueItemAvailable(eventHandler);
                }
            }
        }

        /// <summary>
        /// Unregister for queue events
        /// </summary>
        /// <param name="aec"></param>
        /// <param name="eventHandler"></param>
        private void UnregisterForQueueEvents(ActivityExecutionContext aec,
            IActivityEventListener<QueueEventArgs> eventHandler)
        {
            WorkflowQueuingService queueService
                = aec.GetService<WorkflowQueuingService>();
            if (queueService != null)
            {
                //find the queue and unregister for events
                WorkflowQueue queue = null;
                if (queueService.Exists(_queueName))
                {
                    queue = queueService.GetWorkflowQueue(_queueName);
                }

                queue.UnregisterForQueueItemAvailable(eventHandler);
            }
        }

        /// <summary>
        /// Determine if a new queue message has arrived
        /// </summary>
        /// <param name="aec"></param>
        /// <returns></returns>
        private Boolean HandleQueuedMessage(ActivityExecutionContext aec)
        {
            Boolean result = false;

            //retrieve and process the next queue message
            WorkflowQueuingService queueService
                = aec.GetService<WorkflowQueuingService>();
            if (queueService.Exists(_queueName))
            {
                WorkflowQueue queue
                    = queueService.GetWorkflowQueue(_queueName);
                if (queue.Count == 0)
                {
                    //no messages to process
                    return result;
                }

                //remove the message from the queue
                Int32 guess = (Int32)queue.Dequeue();
                ProcessTheGuess(guess);
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Handle a new guess
        /// </summary>
        /// <param name="guess"></param>
        private void ProcessTheGuess(Int32 guess)
        {
            if (guess < TheNumber)
            {
                Message = "Try a higher number.";
            }
            else if (guess > TheNumber)
            {
                Message = "Try a lower number.";
            }
            else
            {
                Message = String.Format(
                    "Congratulations! You correctly guessed {0}.", TheNumber);
                IsComplete = true;
            }
        }

        #endregion
    }
}
