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

namespace ConsoleInventoryClient
{
	partial class InventoryClientWorkflow
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
            System.Workflow.Activities.ContextToken contexttoken1 = new System.Workflow.Activities.ContextToken();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo1 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.ChannelToken channeltoken1 = new System.Workflow.Activities.ChannelToken();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding3 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding4 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo2 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.ContextToken contexttoken2 = new System.Workflow.Activities.ContextToken();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding5 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo3 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.ChannelToken channeltoken2 = new System.Workflow.Activities.ChannelToken();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding6 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding7 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding8 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo4 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.ContextToken contexttoken3 = new System.Workflow.Activities.ContextToken();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding9 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo5 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.ChannelToken channeltoken3 = new System.Workflow.Activities.ChannelToken();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding10 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding11 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding12 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo6 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.WorkflowServiceAttributes workflowserviceattributes1 = new System.Workflow.Activities.WorkflowServiceAttributes();
            this.codeActivity6 = new System.Workflow.Activities.CodeActivity();
            this.codeActivity4 = new System.Workflow.Activities.CodeActivity();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlerActivity3 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.codeActivity5 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlerActivity2 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.codeActivity3 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlerActivity1 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity3 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.receiveActivity3 = new System.Workflow.Activities.ReceiveActivity();
            this.sendActivity3 = new System.Workflow.Activities.SendActivity();
            this.faultHandlersActivity2 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.receiveActivity2 = new System.Workflow.Activities.ReceiveActivity();
            this.sendActivity2 = new System.Workflow.Activities.SendActivity();
            this.faultHandlersActivity1 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.receiveActivity1 = new System.Workflow.Activities.ReceiveActivity();
            this.sendActivity1 = new System.Workflow.Activities.SendActivity();
            this.sequenceActivity4 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity3 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity1 = new System.Workflow.Activities.SequenceActivity();
            this.parallelActivity1 = new System.Workflow.Activities.ParallelActivity();
            // 
            // codeActivity6
            // 
            this.codeActivity6.Name = "codeActivity6";
            this.codeActivity6.ExecuteCode += new System.EventHandler(this.FaultHandler_ExecuteCode);
            // 
            // codeActivity4
            // 
            this.codeActivity4.Name = "codeActivity4";
            this.codeActivity4.ExecuteCode += new System.EventHandler(this.FaultHandler_ExecuteCode);
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.FaultHandler_ExecuteCode);
            // 
            // faultHandlerActivity3
            // 
            this.faultHandlerActivity3.Activities.Add(this.codeActivity6);
            this.faultHandlerActivity3.FaultType = typeof(System.ServiceModel.FaultException);
            this.faultHandlerActivity3.Name = "faultHandlerActivity3";
            // 
            // codeActivity5
            // 
            this.codeActivity5.Name = "codeActivity5";
            this.codeActivity5.ExecuteCode += new System.EventHandler(this.codeActivity5_ExecuteCode);
            // 
            // faultHandlerActivity2
            // 
            this.faultHandlerActivity2.Activities.Add(this.codeActivity4);
            this.faultHandlerActivity2.FaultType = typeof(System.ServiceModel.FaultException);
            this.faultHandlerActivity2.Name = "faultHandlerActivity2";
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.codeActivity3_ExecuteCode);
            // 
            // faultHandlerActivity1
            // 
            this.faultHandlerActivity1.Activities.Add(this.codeActivity2);
            this.faultHandlerActivity1.FaultType = typeof(System.ServiceModel.FaultException);
            this.faultHandlerActivity1.Name = "faultHandlerActivity1";
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            // 
            // faultHandlersActivity3
            // 
            this.faultHandlersActivity3.Activities.Add(this.faultHandlerActivity3);
            this.faultHandlersActivity3.Name = "faultHandlersActivity3";
            // 
            // receiveActivity3
            // 
            this.receiveActivity3.Activities.Add(this.codeActivity5);
            contexttoken1.Name = "ReturnProduct3";
            contexttoken1.OwnerActivityName = "InventoryClientWorkflow";
            this.receiveActivity3.ContextToken = contexttoken1;
            this.receiveActivity3.Name = "receiveActivity3";
            activitybind1.Name = "InventoryClientWorkflow";
            activitybind1.Path = "product3";
            workflowparameterbinding1.ParameterName = "product";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.receiveActivity3.ParameterBindings.Add(workflowparameterbinding1);
            typedoperationinfo1.ContractType = typeof(ConsoleInventoryHost.IInventoryClientServices);
            typedoperationinfo1.Name = "ReturnProduct";
            this.receiveActivity3.ServiceOperationInfo = typedoperationinfo1;
            // 
            // sendActivity3
            // 
            channeltoken1.EndpointName = "InventoryEndpoint";
            channeltoken1.Name = "LookupProduct3";
            channeltoken1.OwnerActivityName = "sequenceActivity4";
            this.sendActivity3.ChannelToken = channeltoken1;
            this.sendActivity3.Name = "sendActivity3";
            activitybind2.Name = "InventoryClientWorkflow";
            activitybind2.Path = "Id";
            workflowparameterbinding2.ParameterName = "id";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            workflowparameterbinding3.ParameterName = "size";
            workflowparameterbinding3.Value = "L";
            activitybind3.Name = "InventoryClientWorkflow";
            activitybind3.Path = "sendingContext3";
            workflowparameterbinding4.ParameterName = "context";
            workflowparameterbinding4.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.sendActivity3.ParameterBindings.Add(workflowparameterbinding2);
            this.sendActivity3.ParameterBindings.Add(workflowparameterbinding3);
            this.sendActivity3.ParameterBindings.Add(workflowparameterbinding4);
            typedoperationinfo2.ContractType = typeof(ConsoleInventoryHost.IInventoryServices);
            typedoperationinfo2.Name = "LookupProduct";
            this.sendActivity3.ServiceOperationInfo = typedoperationinfo2;
            this.sendActivity3.BeforeSend += new System.EventHandler<System.Workflow.Activities.SendActivityEventArgs>(this.sendActivity3_BeforeSend);
            // 
            // faultHandlersActivity2
            // 
            this.faultHandlersActivity2.Activities.Add(this.faultHandlerActivity2);
            this.faultHandlersActivity2.Name = "faultHandlersActivity2";
            // 
            // receiveActivity2
            // 
            this.receiveActivity2.Activities.Add(this.codeActivity3);
            contexttoken2.Name = "ReturnProduct2";
            contexttoken2.OwnerActivityName = "InventoryClientWorkflow";
            this.receiveActivity2.ContextToken = contexttoken2;
            this.receiveActivity2.Name = "receiveActivity2";
            activitybind4.Name = "InventoryClientWorkflow";
            activitybind4.Path = "product2";
            workflowparameterbinding5.ParameterName = "product";
            workflowparameterbinding5.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.receiveActivity2.ParameterBindings.Add(workflowparameterbinding5);
            typedoperationinfo3.ContractType = typeof(ConsoleInventoryHost.IInventoryClientServices);
            typedoperationinfo3.Name = "ReturnProduct";
            this.receiveActivity2.ServiceOperationInfo = typedoperationinfo3;
            // 
            // sendActivity2
            // 
            channeltoken2.EndpointName = "InventoryEndpoint";
            channeltoken2.Name = "LookupProduct2";
            channeltoken2.OwnerActivityName = "sequenceActivity3";
            this.sendActivity2.ChannelToken = channeltoken2;
            this.sendActivity2.Name = "sendActivity2";
            activitybind5.Name = "InventoryClientWorkflow";
            activitybind5.Path = "Id";
            workflowparameterbinding6.ParameterName = "id";
            workflowparameterbinding6.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            workflowparameterbinding7.ParameterName = "size";
            workflowparameterbinding7.Value = "M";
            activitybind6.Name = "InventoryClientWorkflow";
            activitybind6.Path = "sendingContext2";
            workflowparameterbinding8.ParameterName = "context";
            workflowparameterbinding8.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.sendActivity2.ParameterBindings.Add(workflowparameterbinding6);
            this.sendActivity2.ParameterBindings.Add(workflowparameterbinding7);
            this.sendActivity2.ParameterBindings.Add(workflowparameterbinding8);
            typedoperationinfo4.ContractType = typeof(ConsoleInventoryHost.IInventoryServices);
            typedoperationinfo4.Name = "LookupProduct";
            this.sendActivity2.ServiceOperationInfo = typedoperationinfo4;
            this.sendActivity2.BeforeSend += new System.EventHandler<System.Workflow.Activities.SendActivityEventArgs>(this.sendActivity2_BeforeSend);
            // 
            // faultHandlersActivity1
            // 
            this.faultHandlersActivity1.Activities.Add(this.faultHandlerActivity1);
            this.faultHandlersActivity1.Name = "faultHandlersActivity1";
            // 
            // receiveActivity1
            // 
            this.receiveActivity1.Activities.Add(this.codeActivity1);
            contexttoken3.Name = "ReturnProduct1";
            contexttoken3.OwnerActivityName = "InventoryClientWorkflow";
            this.receiveActivity1.ContextToken = contexttoken3;
            this.receiveActivity1.Name = "receiveActivity1";
            activitybind7.Name = "InventoryClientWorkflow";
            activitybind7.Path = "product1";
            workflowparameterbinding9.ParameterName = "product";
            workflowparameterbinding9.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding9);
            typedoperationinfo5.ContractType = typeof(ConsoleInventoryHost.IInventoryClientServices);
            typedoperationinfo5.Name = "ReturnProduct";
            this.receiveActivity1.ServiceOperationInfo = typedoperationinfo5;
            // 
            // sendActivity1
            // 
            channeltoken3.EndpointName = "InventoryEndpoint";
            channeltoken3.Name = "LookupProduct1";
            channeltoken3.OwnerActivityName = "sequenceActivity1";
            this.sendActivity1.ChannelToken = channeltoken3;
            this.sendActivity1.Name = "sendActivity1";
            activitybind8.Name = "InventoryClientWorkflow";
            activitybind8.Path = "Id";
            workflowparameterbinding10.ParameterName = "id";
            workflowparameterbinding10.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            workflowparameterbinding11.ParameterName = "size";
            workflowparameterbinding11.Value = "S";
            activitybind9.Name = "InventoryClientWorkflow";
            activitybind9.Path = "sendingContext1";
            workflowparameterbinding12.ParameterName = "context";
            workflowparameterbinding12.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            this.sendActivity1.ParameterBindings.Add(workflowparameterbinding10);
            this.sendActivity1.ParameterBindings.Add(workflowparameterbinding11);
            this.sendActivity1.ParameterBindings.Add(workflowparameterbinding12);
            typedoperationinfo6.ContractType = typeof(ConsoleInventoryHost.IInventoryServices);
            typedoperationinfo6.Name = "LookupProduct";
            this.sendActivity1.ServiceOperationInfo = typedoperationinfo6;
            this.sendActivity1.BeforeSend += new System.EventHandler<System.Workflow.Activities.SendActivityEventArgs>(this.sendActivity1_BeforeSend);
            // 
            // sequenceActivity4
            // 
            this.sequenceActivity4.Activities.Add(this.sendActivity3);
            this.sequenceActivity4.Activities.Add(this.receiveActivity3);
            this.sequenceActivity4.Activities.Add(this.faultHandlersActivity3);
            this.sequenceActivity4.Name = "sequenceActivity4";
            // 
            // sequenceActivity3
            // 
            this.sequenceActivity3.Activities.Add(this.sendActivity2);
            this.sequenceActivity3.Activities.Add(this.receiveActivity2);
            this.sequenceActivity3.Activities.Add(this.faultHandlersActivity2);
            this.sequenceActivity3.Name = "sequenceActivity3";
            // 
            // sequenceActivity1
            // 
            this.sequenceActivity1.Activities.Add(this.sendActivity1);
            this.sequenceActivity1.Activities.Add(this.receiveActivity1);
            this.sequenceActivity1.Activities.Add(this.faultHandlersActivity1);
            this.sequenceActivity1.Name = "sequenceActivity1";
            // 
            // parallelActivity1
            // 
            this.parallelActivity1.Activities.Add(this.sequenceActivity1);
            this.parallelActivity1.Activities.Add(this.sequenceActivity3);
            this.parallelActivity1.Activities.Add(this.sequenceActivity4);
            this.parallelActivity1.Name = "parallelActivity1";
            workflowserviceattributes1.ConfigurationName = "ConsoleInventoryClient.InventoryClientWorkflow";
            workflowserviceattributes1.Name = "InventoryClientWorkflow";
            // 
            // InventoryClientWorkflow
            // 
            this.Activities.Add(this.parallelActivity1);
            this.Name = "InventoryClientWorkflow";
            this.SetValue(System.Workflow.Activities.ReceiveActivity.WorkflowServiceAttributesProperty, workflowserviceattributes1);
            this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity codeActivity6;
        private CodeActivity codeActivity4;
        private FaultHandlerActivity faultHandlerActivity3;
        private FaultHandlerActivity faultHandlerActivity2;
        private FaultHandlersActivity faultHandlersActivity1;
        private FaultHandlerActivity faultHandlerActivity1;
        private FaultHandlersActivity faultHandlersActivity3;
        private FaultHandlersActivity faultHandlersActivity2;
        private CodeActivity codeActivity2;
        private CodeActivity codeActivity5;
        private ReceiveActivity receiveActivity3;
        private SendActivity sendActivity3;
        private SequenceActivity sequenceActivity4;
        private CodeActivity codeActivity3;
        private ReceiveActivity receiveActivity2;
        private SendActivity sendActivity2;
        private SequenceActivity sequenceActivity3;
        private SequenceActivity sequenceActivity1;
        private ParallelActivity parallelActivity1;
        private CodeActivity codeActivity1;
        private SendActivity sendActivity1;
        private ReceiveActivity receiveActivity1;
















































    }
}
