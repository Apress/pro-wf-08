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

using ConsoleInventoryHost;

namespace ConsoleInventoryClient
{
    /// <summary>
    /// Client workflow to lookup product inventory
    /// in parallel.  Uses context to correlate callbacks
    /// to the correct parallel branch of execution.
    /// </summary>
    public sealed partial class InventoryClientWorkflow
        : SequentialWorkflowActivity
    {
        public static DependencyProperty IdProperty
            = DependencyProperty.Register("Id", typeof(Int32),
            typeof(InventoryClientWorkflow));

        [DescriptionAttribute("Id")]
        [CategoryAttribute("Id Category")]
        [BrowsableAttribute(true)]
        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        public Int32 Id
        {
            get
            {
                return ((Int32)(base.GetValue(
                    InventoryClientWorkflow.IdProperty)));
            }
            set
            {
                base.SetValue(InventoryClientWorkflow.IdProperty, value);
            }
        }

        public static DependencyProperty ProductsProperty
            = DependencyProperty.Register("Products", typeof(List<Product>),
            typeof(InventoryClientWorkflow));

        [DescriptionAttribute("Products")]
        [CategoryAttribute("Products Category")]
        [BrowsableAttribute(true)]
        [DesignerSerializationVisibilityAttribute(
            DesignerSerializationVisibility.Visible)]
        public List<Product> Products
        {
            get
            {
                return ((List<Product>)(base.GetValue(
                    InventoryClientWorkflow.ProductsProperty)));
            }
            set
            {
                base.SetValue(InventoryClientWorkflow.ProductsProperty, value);
            }
        }

        public Product product1 = new ConsoleInventoryHost.Product();
        public IDictionary<String, String> sendingContext1
            = default(IDictionary<System.String, System.String>);

        public Product product2 = new ConsoleInventoryHost.Product();
        public IDictionary<String, String> sendingContext2
            = default(IDictionary<System.String, System.String>);

        public Product product3 = new ConsoleInventoryHost.Product();
        public IDictionary<String, String> sendingContext3
            = default(IDictionary<System.String, System.String>);

        public InventoryClientWorkflow()
        {
            InitializeComponent();

            //initialize the list of products
            Products = new List<Product>();
        }

        /// <summary>
        /// Pass the receiving context to the sendActivity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendActivity1_BeforeSend(
            object sender, SendActivityEventArgs e)
        {
            this.sendingContext1 = receiveActivity1.Context;
        }

        /// <summary>
        /// Add the newly returned product to the
        /// collection of products that is the final result
        /// of this workflow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void codeActivity1_ExecuteCode(
            object sender, EventArgs e)
        {
            Products.Add(product1);
        }

        private void sendActivity2_BeforeSend(
            object sender, SendActivityEventArgs e)
        {
            this.sendingContext2 = receiveActivity2.Context;
        }

        private void codeActivity3_ExecuteCode(
            object sender, EventArgs e)
        {
            Products.Add(product2);
        }

        private void sendActivity3_BeforeSend(
            object sender, SendActivityEventArgs e)
        {
            this.sendingContext3 = receiveActivity3.Context;
        }

        private void codeActivity5_ExecuteCode(
            object sender, EventArgs e)
        {
            Products.Add(product3);
        }

        /// <summary>
        /// Handle a FaultException that is raised by 
        /// the inventory service when the size or ID
        /// are invalid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FaultHandler_ExecuteCode(
            object sender, EventArgs e)
        {
            Activity activity = sender as Activity;
            String message = String.Empty;
            if (activity != null)
            {
                message = ((FaultHandlerActivity)activity.Parent).Fault.Message;
            }

            Console.WriteLine("Service Fault Received: {0}", message);
        }
    }
}
