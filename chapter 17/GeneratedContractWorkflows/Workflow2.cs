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
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace GeneratedContractWorkflows
{
	public sealed partial class Workflow2: SequentialWorkflowActivity
	{
		public Workflow2()
		{
			InitializeComponent();
		}

        public String ReturnValue = default(System.String);
        public static DependencyProperty Param1Property = DependencyProperty.Register("Param1", typeof(System.Int32), typeof(GeneratedContractWorkflows.Workflow2));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Int32 Param1
        {
            get
            {
                return ((int)(base.GetValue(GeneratedContractWorkflows.Workflow2.Param1Property)));
            }
            set
            {
                base.SetValue(GeneratedContractWorkflows.Workflow2.Param1Property, value);
            }
        }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            ReturnValue = Param1.ToString();
        }
	}

}
