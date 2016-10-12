﻿//--------------------------------------------------------------------------------
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
using System.ServiceModel;

namespace SharedWorkflows
{
    [ServiceContract(Namespace = "http://ProWF",
        SessionMode = SessionMode.NotAllowed)]
    public interface IMathService
    {
        /// <summary>
        /// Perform a division operation
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        [OperationContract]
        Double DivideNumbers(Double dividend, Double divisor);
    }
}
