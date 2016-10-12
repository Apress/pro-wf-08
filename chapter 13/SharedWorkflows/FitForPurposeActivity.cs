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
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Activities;

namespace SharedWorkflows
{
    [Designer(typeof(ActivityDesigner), typeof(IDesigner))]
    public partial class FitForPurposeActivity : SequenceActivity
    {
        public static DependencyProperty TestValueProperty
            = DependencyProperty.Register("TestValue",
            typeof(String), typeof(FitForPurposeActivity));

        [DescriptionAttribute("TestValue")]
        [CategoryAttribute("Advanced Activities Category")]
        [BrowsableAttribute(true)]
        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        public String TestValue
        {
            get
            {
                return ((String)(base.GetValue(
                    FitForPurposeActivity.TestValueProperty)));
            }
            set
            {
                base.SetValue(
                    FitForPurposeActivity.TestValueProperty, value);
            }
        }

        public FitForPurposeActivity()
        {
            InitializeComponent();
        }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine(
                "Executing 1st CodeActivity with value {0}", TestValue);
        }

        private void codeActivity2_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine(
                "Executing 2nd CodeActivity with value {0}", TestValue);
        }
    }
}
