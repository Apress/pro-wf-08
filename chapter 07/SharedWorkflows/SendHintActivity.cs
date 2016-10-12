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

namespace SharedWorkflows
{
    /// <summary>
    /// An activity that sends a string hint directly to
    /// a host application.
    /// </summary>
    /// <remarks>
    /// This activity directly references the host application 
    /// as a workflow service instead of calling a local service method.
    /// </remarks>
    public partial class SendHintActivity : Activity
    {
        #region Dependency Properties

        public static DependencyProperty MessageProperty
            = System.Workflow.ComponentModel.DependencyProperty.Register(
            "Message", typeof(String), typeof(SendHintActivity));

        [Description("A hint message")]
        [Category("Event Handling")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public String Message
        {
            get
            {
                return ((String)(base.GetValue(SendHintActivity.MessageProperty)));
            }
            set
            {
                base.SetValue(SendHintActivity.MessageProperty, value);
            }
        }

        #endregion

        public SendHintActivity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Primary execution method
        /// </summary>
        /// <param name="executionContext"></param>
        /// <returns></returns>
        protected override ActivityExecutionStatus Execute(
            ActivityExecutionContext executionContext)
        {
            //retrieve the service that supports the interface
            //needed to send messages.
            ISendMessageService service =
                executionContext.GetService<ISendMessageService>();
            if (service != null)
            {
                //pass the string message 
                service.SendMessage(Message);
            }

            return ActivityExecutionStatus.Closed;
        }
    }
}
