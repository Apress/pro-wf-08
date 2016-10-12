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
using System.Workflow.Runtime;
using System.Workflow.ComponentModel;

namespace SharedWorkflows
{
    /// <summary>
    /// An activity that handles a long running task
    /// </summary>
    public partial class LongRunningActivity : Activity,
        IActivityEventListener<QueueEventArgs>
    {
        #region Properties

        public static DependencyProperty WorkDataProperty
            = DependencyProperty.Register("WorkData",
            typeof(string), typeof(LongRunningActivity));

        [DescriptionAttribute("WorkData")]
        [CategoryAttribute("Long Running Category")]
        [BrowsableAttribute(true)]
        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        public string WorkData
        {
            get
            {
                return ((string)(base.GetValue(
                    LongRunningActivity.WorkDataProperty)));
            }
            set
            {
                base.SetValue(LongRunningActivity.WorkDataProperty, value);
            }
        }

        #endregion

        /// <summary>
        /// Each instance of this activity will get a unique queue name
        /// </summary>
        private String _queueName = Guid.NewGuid().ToString();

        public LongRunningActivity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Override the Execute method
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        protected override ActivityExecutionStatus Execute(
            ActivityExecutionContext executionContext)
        {
            //get our custom service
            ILongRunningServices longRunningService
                = executionContext.GetService(typeof(ILongRunningServices))
                    as ILongRunningServices;
            if (longRunningService == null)
            {
                throw new NullReferenceException(
                    "Unable to retrieve ILongRunningServices");
            }

            //get the workflow queuing service
            WorkflowQueuingService queueService
                = executionContext.GetService(typeof(WorkflowQueuingService))
                    as WorkflowQueuingService;
            if (queueService == null)
            {
                throw new NullReferenceException(
                    "Unable to retrieve WorkflowQueuingService");
            }

            //create a workflow queue for the response from the service
            WorkflowQueue queue
                = queueService.CreateWorkflowQueue(_queueName, true);
            //register for an event when a queue item is available
            queue.RegisterForQueueItemAvailable(this);

            //make the call to the long running service
            WorkRequest request = new WorkRequest(
                this.WorkflowInstanceId, _queueName, WorkData);
            Console.WriteLine("Calling service: {0}", WorkData);
            longRunningService.DoLongRunningWork(request);

            //tell the runtime that we are still executing
            return ActivityExecutionStatus.Executing;
        }

        #region IActivityEventListener<QueueEventArgs> Members

        /// <summary>
        /// Result received from the service via a queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnEvent(object sender, QueueEventArgs e)
        {
            //the sender is an AEC
            ActivityExecutionContext aec
                = sender as ActivityExecutionContext;

            //get the queuing service and our input queue
            WorkflowQueuingService queueService
                = aec.GetService<WorkflowQueuingService>();
            WorkflowQueue queue
                = queueService.GetWorkflowQueue(e.QueueName);

            if (queue != null && queue.Count > 0)
            {
                //get the response from the queue.
                WorkResponse response = queue.Dequeue() as WorkResponse;
                if (response != null)
                {
                    Console.WriteLine("Response: {0}", response.Result);
                }
            }

            //delete the queue
            queueService.DeleteWorkflowQueue(e.QueueName);

            //now signal that we're done
            aec.CloseActivity();
        }

        #endregion
    }
}
