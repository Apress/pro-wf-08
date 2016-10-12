using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace ConsoleInventoryHost
{
	partial class InventoryServiceWorkflow
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
            this.CanModifyActivities = true;
            System.Workflow.Activities.ChannelToken channeltoken1 = new System.Workflow.Activities.ChannelToken();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo1 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding3 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding4 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo2 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.WorkflowServiceAttributes workflowserviceattributes1 = new System.Workflow.Activities.WorkflowServiceAttributes();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.sendActivity1 = new System.Workflow.Activities.SendActivity();
            this.receiveActivity1 = new System.Workflow.Activities.ReceiveActivity();
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            // 
            // sendActivity1
            // 
            channeltoken1.EndpointName = "CallingClient.IInventoryClientServices";
            channeltoken1.Name = "ReturnProduct";
            channeltoken1.OwnerActivityName = "InventoryServiceWorkflow";
            this.sendActivity1.ChannelToken = channeltoken1;
            this.sendActivity1.Name = "sendActivity1";
            activitybind1.Name = "InventoryServiceWorkflow";
            activitybind1.Path = "ReturnProduct";
            workflowparameterbinding1.ParameterName = "product";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.sendActivity1.ParameterBindings.Add(workflowparameterbinding1);
            typedoperationinfo1.ContractType = typeof(ConsoleInventoryHost.IInventoryClientServices);
            typedoperationinfo1.Name = "ReturnProduct";
            this.sendActivity1.ServiceOperationInfo = typedoperationinfo1;
            this.sendActivity1.BeforeSend += new System.EventHandler<System.Workflow.Activities.SendActivityEventArgs>(this.sendActivity1_BeforeSend);
            // 
            // receiveActivity1
            // 
            this.receiveActivity1.Activities.Add(this.codeActivity1);
            this.receiveActivity1.CanCreateInstance = true;
            this.receiveActivity1.Name = "receiveActivity1";
            activitybind2.Name = "InventoryServiceWorkflow";
            activitybind2.Path = "Id";
            workflowparameterbinding2.ParameterName = "id";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            activitybind3.Name = "InventoryServiceWorkflow";
            activitybind3.Path = "Size";
            workflowparameterbinding3.ParameterName = "size";
            workflowparameterbinding3.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            activitybind4.Name = "InventoryServiceWorkflow";
            activitybind4.Path = "ReturnContext";
            workflowparameterbinding4.ParameterName = "context";
            workflowparameterbinding4.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding2);
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding3);
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding4);
            typedoperationinfo2.ContractType = typeof(ConsoleInventoryHost.IInventoryServices);
            typedoperationinfo2.Name = "LookupProduct";
            this.receiveActivity1.ServiceOperationInfo = typedoperationinfo2;
            workflowserviceattributes1.ConfigurationName = "ConsoleInventoryHost.InventoryServiceWorkflow";
            workflowserviceattributes1.Name = "InventoryServiceWorkflow";
            // 
            // InventoryServiceWorkflow
            // 
            this.Activities.Add(this.receiveActivity1);
            this.Activities.Add(this.sendActivity1);
            this.Name = "InventoryServiceWorkflow";
            this.SetValue(System.Workflow.Activities.ReceiveActivity.WorkflowServiceAttributesProperty, workflowserviceattributes1);
            this.CanModifyActivities = false;

		}

		#endregion

        private SendActivity sendActivity1;
        private CodeActivity codeActivity1;
        private ReceiveActivity receiveActivity1;





















    }
}
