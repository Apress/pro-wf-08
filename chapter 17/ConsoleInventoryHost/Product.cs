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
using System.Runtime.Serialization;

namespace ConsoleInventoryHost
{
    [Serializable]
    [DataContract(Namespace = "http://ProWF")]
    public class Product
    {
        [DataMember]
        public Int32 Id { get; set; }
        
        [DataMember]
        public String Size { get; set; }

        [DataMember]
        public String Description { get; set; }

        [DataMember]
        public Decimal Price { get; set; }

        [DataMember]
        public Int32 Inventory { get; set; }
    }
}
