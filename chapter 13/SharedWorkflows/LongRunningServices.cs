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
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

namespace SharedWorkflows
{
    /// <summary>
    /// Implements a custom service that handles
    /// long running requests
    /// </summary>
    public class LongRunningServices : WorkflowRuntimeService,
        ILongRunningServices
    {
        private Random _random = new Random();

        #region ILongRunningServices Members

        public void DoLongRunningWork(WorkRequest workToDo)
        {
            //queue this work to the thread pool so we 
            //can return immediately
            ThreadPool.QueueUserWorkItem(
                ThreadPoolWorkCallback, workToDo);
            Console.WriteLine("Queued work: {0}",
                workToDo.RequestedWork);
        }

        #endregion

        private void ThreadPoolWorkCallback(Object state)
        {
            WorkRequest request = state as WorkRequest;
            if (request == null)
            {
                throw new ArgumentException(
                    "WorkRequest was expected", "state");
            }

            WorkflowInstance instance
                = Runtime.GetWorkflow(request.InstanceId);
            if (instance == null)
            {
                throw new ArgumentException(
                    "Not a valid workflow instance", "InstanceId");
            }

            //simulate a long-running task by just sleeping
            Int32 ms = _random.Next(1000, 5000);
            Thread.Sleep(ms);

            //send the response back to the requesting activity
            //via the named queue
            WorkResponse response = new WorkResponse(String.Format(
                "Task-{0}-Result-{1}", request.RequestedWork, ms));
            instance.EnqueueItem(
                request.ResponseQueueName, response, null, null);
        }
    }
}
