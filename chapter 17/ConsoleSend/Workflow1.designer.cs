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

namespace ConsoleSend
{
	partial class Workflow1
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
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo1 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo2 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding3 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding4 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo3 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo4 = new System.Workflow.Activities.TypedOperationInfo();
            this.sendActivity4 = new System.Workflow.Activities.SendActivity();
            this.sendActivity3 = new System.Workflow.Activities.SendActivity();
            this.sendActivity2 = new System.Workflow.Activities.SendActivity();
            this.sendActivity1 = new System.Workflow.Activities.SendActivity();
            // 
            // sendActivity4
            // 
            channeltoken1.EndpointName = "MathEndpoint";
            channeltoken1.Name = "MathChannel";
            channeltoken1.OwnerActivityName = "Workflow1";
            this.sendActivity4.ChannelToken = channeltoken1;
            this.sendActivity4.Name = "sendActivity4";
            typedoperationinfo1.ContractType = typeof(SharedWorkflows.IMathServiceStateful);
            typedoperationinfo1.Name = "StopWorkflow";
            this.sendActivity4.ServiceOperationInfo = typedoperationinfo1;
            // 
            // sendActivity3
            // 
            this.sendActivity3.ChannelToken = channeltoken1;
            this.sendActivity3.Name = "sendActivity3";
            activitybind1.Name = "Workflow1";
            activitybind1.Path = "LastQuotient";
            workflowparameterbinding1.ParameterName = "(ReturnValue)";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.sendActivity3.ParameterBindings.Add(workflowparameterbinding1);
            typedoperationinfo2.ContractType = typeof(SharedWorkflows.IMathServiceStateful);
            typedoperationinfo2.Name = "GetLastQuotient";
            this.sendActivity3.ServiceOperationInfo = typedoperationinfo2;
            // 
            // sendActivity2
            // 
            this.sendActivity2.ChannelToken = channeltoken1;
            this.sendActivity2.Name = "sendActivity2";
            activitybind2.Name = "Workflow1";
            activitybind2.Path = "Quotient";
            workflowparameterbinding2.ParameterName = "(ReturnValue)";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            activitybind3.Name = "Workflow1";
            activitybind3.Path = "Dividend";
            workflowparameterbinding3.ParameterName = "dividend";
            workflowparameterbinding3.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            activitybind4.Name = "Workflow1";
            activitybind4.Path = "Divisor";
            workflowparameterbinding4.ParameterName = "divisor";
            workflowparameterbinding4.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.sendActivity2.ParameterBindings.Add(workflowparameterbinding2);
            this.sendActivity2.ParameterBindings.Add(workflowparameterbinding3);
            this.sendActivity2.ParameterBindings.Add(workflowparameterbinding4);
            typedoperationinfo3.ContractType = typeof(SharedWorkflows.IMathServiceStateful);
            typedoperationinfo3.Name = "DivideNumbers";
            this.sendActivity2.ServiceOperationInfo = typedoperationinfo3;
            // 
            // sendActivity1
            // 
            this.sendActivity1.ChannelToken = channeltoken1;
            this.sendActivity1.Name = "sendActivity1";
            typedoperationinfo4.ContractType = typeof(SharedWorkflows.IMathServiceStateful);
            typedoperationinfo4.Name = "StartWorkflow";
            this.sendActivity1.ServiceOperationInfo = typedoperationinfo4;
            // 
            // Workflow1
            // 
            this.Activities.Add(this.sendActivity1);
            this.Activities.Add(this.sendActivity2);
            this.Activities.Add(this.sendActivity3);
            this.Activities.Add(this.sendActivity4);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private SendActivity sendActivity4;
        private SendActivity sendActivity3;
        private SendActivity sendActivity2;
        private SendActivity sendActivity1;






















    }
}
