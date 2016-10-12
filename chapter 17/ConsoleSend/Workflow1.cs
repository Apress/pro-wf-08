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
using System.Workflow.ComponentModel;
using System.Workflow.Activities;

namespace ConsoleSend
{
    /// <summary>
    /// A workflow that demonstrates the SendActivity
    /// </summary>
    public sealed partial class Workflow1
        : SequentialWorkflowActivity
    {
        public Workflow1()
        {
            InitializeComponent();
        }

        public static DependencyProperty DividendProperty
            = DependencyProperty.Register("Dividend", typeof(System.Double),
            typeof(ConsoleSend.Workflow1));

        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Double Dividend
        {
            get
            {
                return ((double)(base.GetValue(
                    ConsoleSend.Workflow1.DividendProperty)));
            }
            set
            {
                base.SetValue(ConsoleSend.Workflow1.DividendProperty, value);
            }
        }

        public static DependencyProperty QuotientProperty
            = DependencyProperty.Register("Quotient", typeof(System.Double),
            typeof(ConsoleSend.Workflow1));

        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Double Quotient
        {
            get
            {
                return ((double)(base.GetValue(
                    ConsoleSend.Workflow1.QuotientProperty)));
            }
            set
            {
                base.SetValue(ConsoleSend.Workflow1.QuotientProperty, value);
            }
        }

        public static DependencyProperty DivisorProperty
            = DependencyProperty.Register("Divisor", typeof(System.Double),
            typeof(ConsoleSend.Workflow1));

        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Double Divisor
        {
            get
            {
                return ((double)(base.GetValue(
                    ConsoleSend.Workflow1.DivisorProperty)));
            }
            set
            {
                base.SetValue(ConsoleSend.Workflow1.DivisorProperty, value);
            }
        }

        public static DependencyProperty LastQuotientProperty
            = DependencyProperty.Register("LastQuotient", typeof(System.Double),
            typeof(ConsoleSend.Workflow1));

        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Double LastQuotient
        {
            get
            {
                return ((double)(base.GetValue(
                    ConsoleSend.Workflow1.LastQuotientProperty)));
            }
            set
            {
                base.SetValue(ConsoleSend.Workflow1.LastQuotientProperty, value);
            }
        }
    }
}
