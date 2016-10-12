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
using System.Collections.Generic;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

namespace ConsoleSend
{
    /// <summary>
    /// Execute a workflow which uses the SendActivity
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (WorkflowRuntime workflowRuntime = new WorkflowRuntime())
            {
                AutoResetEvent waitHandle = new AutoResetEvent(false);
                workflowRuntime.WorkflowCompleted += delegate(
                    object sender, WorkflowCompletedEventArgs e)
                {
                    Console.WriteLine("Quotient is {0}",
                        e.OutputParameters["Quotient"]);
                    Console.WriteLine("LastQuotient is {0}",
                        e.OutputParameters["LastQuotient"]);
                    waitHandle.Set();
                };
                workflowRuntime.WorkflowTerminated += delegate(
                    object sender, WorkflowTerminatedEventArgs e)
                {
                    Console.WriteLine(e.Exception.Message);
                    waitHandle.Set();
                };

                //create channel manager service in order to manage and
                //reuse WCF channels. 
                workflowRuntime.AddService(new ChannelManagerService());

                Dictionary<String, Object> parameters 
                    = new Dictionary<string, object>();
                parameters.Add("Dividend", 5555);
                parameters.Add("Divisor", 5);

                WorkflowInstance instance = workflowRuntime.CreateWorkflow(
                    typeof(ConsoleSend.Workflow1), parameters);
                instance.Start();

                waitHandle.WaitOne();

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
