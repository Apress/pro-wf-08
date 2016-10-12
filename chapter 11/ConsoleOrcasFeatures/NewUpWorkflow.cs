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

namespace SharedWorkflows
{
	public sealed partial class NewUpWorkflow: SequentialWorkflowActivity
	{
        public static DependencyProperty ResultValueProperty = DependencyProperty.Register("ResultValue", typeof(MyClass), typeof(NewUpWorkflow));

        [DescriptionAttribute("Result")]
        [CategoryAttribute("Result Category")]
        [BrowsableAttribute(true)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        public MyClass ResultValue
        {
            get
            {
                return ((MyClass)(base.GetValue(NewUpWorkflow.ResultValueProperty)));
            }
            set
            {
                base.SetValue(NewUpWorkflow.ResultValueProperty, value);
            }
        }

        public static DependencyProperty InputValueProperty = DependencyProperty.Register("InputValue", typeof(MyClass), typeof(NewUpWorkflow));

        [DescriptionAttribute("InputValue")]
        [CategoryAttribute("InputValue Category")]
        [BrowsableAttribute(true)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        public MyClass InputValue
        {
            get
            {
                return ((MyClass)(base.GetValue(NewUpWorkflow.InputValueProperty)));
            }
            set
            {
                base.SetValue(NewUpWorkflow.InputValueProperty, value);
            }
        }

        public static DependencyProperty PostalCodeProperty = DependencyProperty.Register("PostalCode", typeof(string), typeof(NewUpWorkflow));

        [DescriptionAttribute("PostalCode")]
        [CategoryAttribute("PostalCode Category")]
        [BrowsableAttribute(true)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        public string PostalCode
        {
            get
            {
                return ((string)(base.GetValue(NewUpWorkflow.PostalCodeProperty)));
            }
            set
            {
                base.SetValue(NewUpWorkflow.PostalCodeProperty, value);
            }
        }

        protected override void Initialize(System.IServiceProvider provider)
        {
            InputValue = new MyClass("initial value", 1);
            PostalCode = String.Empty;
            base.Initialize(provider);
        }

		public NewUpWorkflow()
		{
			InitializeComponent();
		}
	}

}
