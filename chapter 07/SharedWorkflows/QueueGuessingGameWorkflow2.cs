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
using System.Workflow.Activities;
using System.Workflow.ComponentModel;

namespace SharedWorkflows
{
    /// <summary>
    /// The guessing game workflow using custom queue-based 
    /// event driven activities.
    /// </summary>
    /// <remarks>
    /// This version does not use the EventDrivenActivity as a parent
    /// activity.
    /// </remarks>
    public sealed partial class QueueGuessingGameWorkflow2
        : SequentialWorkflowActivity
    {
        #region Variables and Properties

        public Int32 TheNumber { get; set; }
        public String Message { get; set; }
        public Boolean IsComplete { get; set; }

        #endregion

        public QueueGuessingGameWorkflow2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize variables as the workflow is started
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnInitialized(object sender, EventArgs e)
        {
            Random random = new Random();
            TheNumber = random.Next(1, 10);
            Message = "Please guess a number between 1 and 10.";
        }
    }
}
