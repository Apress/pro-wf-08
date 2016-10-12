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
using System.ComponentModel;
using System.Workflow.ComponentModel;
using System.Workflow.Activities;
using System.ServiceModel;

namespace ConsoleInventoryHost
{
    /// <summary>
    /// A workflow that performs an inventory lookup of
    /// a requested product
    /// </summary>
    public sealed partial class InventoryServiceWorkflow
        : SequentialWorkflowActivity
    {
        public InventoryServiceWorkflow()
        {
            InitializeComponent();
        }

        public static DependencyProperty ReturnProductProperty
            = DependencyProperty.Register("ReturnProduct",
            typeof(Product),
            typeof(InventoryServiceWorkflow));

        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Product ReturnProduct
        {
            get
            {
                return ((Product)(base.GetValue(
                    InventoryServiceWorkflow.ReturnProductProperty)));
            }
            set
            {
                base.SetValue(
                    InventoryServiceWorkflow.ReturnProductProperty, value);
            }
        }

        public static DependencyProperty IdProperty
            = DependencyProperty.Register("Id", typeof(System.Int32),
            typeof(InventoryServiceWorkflow));

        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Int32 Id
        {
            get
            {
                return ((int)(base.GetValue(
                    InventoryServiceWorkflow.IdProperty)));
            }
            set
            {
                base.SetValue(
                    InventoryServiceWorkflow.IdProperty, value);
            }
        }

        public static DependencyProperty SizeProperty
            = DependencyProperty.Register("Size", typeof(System.String),
            typeof(InventoryServiceWorkflow));

        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public String Size
        {
            get
            {
                return ((string)(base.GetValue(
                    InventoryServiceWorkflow.SizeProperty)));
            }
            set
            {
                base.SetValue(
                    InventoryServiceWorkflow.SizeProperty, value);
            }
        }

        public static DependencyProperty ReturnContextProperty
            = DependencyProperty.Register("ReturnContext",
            typeof(IDictionary<System.String, System.String>),
            typeof(InventoryServiceWorkflow));

        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public IDictionary<String, String> ReturnContext
        {
            get
            {
                return ((IDictionary<string, string>)
                    (base.GetValue(
                    InventoryServiceWorkflow.ReturnContextProperty)));
            }
            set
            {
                base.SetValue(
                    InventoryServiceWorkflow.ReturnContextProperty, value);
            }
        }

        /// <summary>
        /// Simulate a lookup of a product based on the Id and Size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            ReturnProduct = null;

            switch (Id)
            {
                case 1001:
                    {
                        Product p = new Product();
                        p = new Product();
                        p.Id = Id;
                        p.Description = "Product 1001";
                        p.Price = 123.45M;
                        if (Size == "S")
                        {
                            p.Size = Size;
                            p.Inventory = 5;
                            ReturnProduct = p;
                        }
                        else if (Size == "M")
                        {
                            p.Size = Size;
                            p.Inventory = 10;
                            ReturnProduct = p;
                        }
                        else if (Size == "L")
                        {
                            p.Size = Size;
                            p.Inventory = 20;
                            ReturnProduct = p;
                        }
                    }
                    break;
                case 2002:
                    {
                        Product p = new Product();
                        p = new Product();
                        p.Id = Id;
                        p.Description = "Product 2002";
                        p.Price = 59.95M;
                        if (Size == "M")
                        {
                            p.Size = Size;
                            p.Inventory = 100;
                            ReturnProduct = p;
                        }
                        else
                        {
                            throw new FaultException<String>(
                                "Invalid Argument", String.Format(
                                "Size {0} is invalid for this product", Size));
                        }
                    }
                    break;
                default:
                    throw new FaultException<String>("Invalid Argument",
                        String.Format("Product Id {0} is invalid", Id));
            }
        }

        /// <summary>
        /// Set the context before invoking 
        /// an operation on the original caller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendActivity1_BeforeSend(
            object sender, SendActivityEventArgs e)
        {
            //pass the context back to the sender
            sendActivity1.Context = ReturnContext;
        }
    }
}
