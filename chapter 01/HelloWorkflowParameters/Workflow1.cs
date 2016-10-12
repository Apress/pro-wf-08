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

namespace HelloWorkflow
{
    public sealed partial class Workflow1 : SequentialWorkflowActivity
    {
        /// <summary>
        /// The target of the greeting
        /// </summary>
        public String Person { get; set; }

        /// <summary>
        /// The greeting message
        /// </summary>
        public String Message { get; set; }

        public Workflow1()
        {
            InitializeComponent();
        }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            //display the variable greeting
            Console.WriteLine("Hello {0}, {1}", Person, Message);
        }
    }
}
