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
    /// A workflow exposed as a web service
    /// </summary>
    public sealed partial class MathServiceFaultsWorkflow
        : SequentialWorkflowActivity
    {
        public Double dividend;
        public Double divisor;
        public Double quotient;

        public MathServiceFaultsWorkflow()
        {
            InitializeComponent();
        }

        private void codeDoDivision_ExecuteCode(
            object sender, EventArgs e)
        {
            //do the division
            quotient = dividend / divisor;
        }

        private void IsDivisorZero(
            object sender, ConditionalEventArgs e)
        {
            e.Result = (divisor == 0);
        }

        public Exception fault =
            new DivideByZeroException("divisor must not be zero");
    }
}
