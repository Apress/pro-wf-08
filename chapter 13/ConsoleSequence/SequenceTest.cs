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
using System.Workflow.Runtime;
using Bukovics.Workflow.Hosting;
using SharedWorkflows;

namespace ConsoleSequence
{
    public class SequenceTest
    {
        public static void Run()
        {
            using (WorkflowRuntimeManager manager
                = new WorkflowRuntimeManager(new WorkflowRuntime()))
            {
                manager.WorkflowRuntime.StartRuntime();
#if CANCELWORKFLOW
                Console.WriteLine("Executing ProWFSequenceCancelWorkflow");
                WorkflowInstanceWrapper instance = manager.StartWorkflow(
                    typeof(SharedWorkflows.ProWFSequenceCancelWorkflow), null);
                manager.WaitAll(10000);
                Console.WriteLine("Completed ProWFSequenceCancelWorkflow\n\r");
#elif SEQUENCEPRIORITY
                Console.WriteLine("Executing SequencePriorityWorkflow");
                WorkflowInstanceWrapper instance = manager.StartWorkflow(
                    typeof(SharedWorkflows.SequencePriorityWorkflow), null);
                manager.WaitAll(2000);
                Console.WriteLine("Completed SequencePriorityWorkflow\n\r");
#else
                Console.WriteLine("Executing ProWFSequenceWorkflow");
                WorkflowInstanceWrapper instance = manager.StartWorkflow(
                    typeof(SharedWorkflows.ProWFSequenceWorkflow), null);
                manager.WaitAll(2000);
                Console.WriteLine("Completed ProWFSequenceWorkflow\n\r");
#endif
            }
        }
    }
}
