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
    /// A simple workflow used to demonstrate tracking
    /// </summary>
    public sealed partial class TrackingUserDataWorkflow
        : SequentialWorkflowActivity
    {
        public TrackingUserDataWorkflow()
        {
            InitializeComponent();
        }

        private void codeFirstActivity_ExecuteCode(
            object sender, EventArgs e)
        {
            Console.WriteLine("Executing first activity");
            TrackData("accountKey", 123456);
        }

        private void codeLastActivity_ExecuteCode(
            object sender, EventArgs e)
        {
            Console.WriteLine("Executing second activity");
            TrackData("approvalMessage", "approved");
        }
    }
}
