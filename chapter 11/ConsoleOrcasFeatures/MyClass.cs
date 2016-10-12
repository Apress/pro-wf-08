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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedWorkflows
{
	public class MyClass
	{
        public String CategoryCode = String.Empty;
        public Int32 InventoryAllowance = 0;

        public MyClass()
        {
        }

        public MyClass(String field1, Int32 field2)
        {
            CategoryCode = field1;
            InventoryAllowance = field2;
        }

        public Boolean Validate(String field1)
        {
            return true;
        }

        public static MyClass operator+(MyClass lValue, MyClass rValue)
        {
            MyClass result = new MyClass();
            //addition logic to be implemented
            return result;
        }
	}
}
