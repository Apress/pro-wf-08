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
    /// EventArgs to demonstrate the use of correlation attributes
    /// </summary>
    [Serializable]
    public class CorrelationExampleEventArgs : ExternalDataEventArgs
    {
        public Int32 BranchId { get; set; }
        public Int32 EventData { get; set; }

        public CorrelationExampleEventArgs(Guid instanceId,
            Int32 branchId, Int32 eventData)
            : base(instanceId)
        {
            BranchId = branchId;
            EventData = eventData;
        }
    }
}
