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

namespace SimpleCalculatorWorkflow
{
    public sealed partial class Workflow1 : SequentialWorkflowActivity
    {
        public String Operation { get; set; }
        public Int32 Number1 { get; set; }
        public Int32 Number2 { get; set; }
        public Double Result { get; set; }

        public Workflow1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add the numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOperation(object sender, EventArgs e)
        {
            Result = Number1 + Number2;
        }

        /// <summary>
        /// Subtract the numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubtractOperation(object sender, EventArgs e)
        {
            Result = Number1 - Number2;
        }

        /// <summary>
        /// Multiply the numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyOperation(object sender, EventArgs e)
        {
            Result = Number1 * Number2;
        }

        /// <summary>
        /// Divide the numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivideOperation(object sender, EventArgs e)
        {
            if (Number2 != 0)
            {
                Result = (Double)Number1 / (Double)Number2;
            }
            else
            {
                Result = 0;
            }
        }

        /// <summary>
        /// Handle invalid operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnknownOperation(object sender, EventArgs e)
        {
            throw new ArgumentException(String.Format(
                "Invalid operation of {0} requested", Operation));
        }
    }
}
