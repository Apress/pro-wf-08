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
using System.Workflow.Activities;

namespace SharedWorkflows
{
    /// <summary>
    /// Workflow that demonstrates EventHandlingScopeActivity
    /// </summary>
    public sealed partial class ScopeExampleWorkflow
        : SequentialWorkflowActivity
    {
        public Boolean IsComplete { get; set; }

        public ScopeExampleWorkflow()
        {
            InitializeComponent();
        }

        private void codeMainlineMessage_ExecuteCode(
            object sender, EventArgs e)
        {
            Console.WriteLine("Executing the workflow main line");
        }

        private void handleEventOne_Invoked(
            object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("Got EventOne");
        }

        private void handleEventTwo_Invoked(
            object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("Got EventTwo");
        }

        private void handleEventStop_Invoked(
            object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("Got EventStop");

            //set the variable that will tell the WhileActivity to stop
            IsComplete = true;
        }
    }
}
