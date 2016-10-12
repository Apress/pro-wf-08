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

namespace SharedWorkflows
{
    /// <summary>
    /// Defines the members that are invoked
    /// by a workflow to communicate with the
    /// host application.
    /// </summary>
    public interface ISendMessageService
    {
        /// <summary>
        /// Send a message from the workflow to the local service
        /// </summary>
        /// <param name="message"></param>
        void SendMessage(String message);
    }
}
