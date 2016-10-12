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

namespace SharedWorkflows
{
	partial class MathServiceWorkflow
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
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding3 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.TypedOperationInfo typedoperationinfo1 = new System.Workflow.Activities.TypedOperationInfo();
            System.Workflow.Activities.WorkflowServiceAttributes workflowserviceattributes1 = new System.Workflow.Activities.WorkflowServiceAttributes();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.receiveActivity1 = new System.Workflow.Activities.ReceiveActivity();
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            // 
            // receiveActivity1
            // 
            this.receiveActivity1.Activities.Add(this.codeActivity1);
            this.receiveActivity1.CanCreateInstance = true;
            this.receiveActivity1.Name = "receiveActivity1";
            activitybind1.Name = "MathServiceWorkflow";
            activitybind1.Path = "returnValue";
            workflowparameterbinding1.ParameterName = "(ReturnValue)";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            activitybind2.Name = "MathServiceWorkflow";
            activitybind2.Path = "dividend";
            workflowparameterbinding2.ParameterName = "dividend";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            activitybind3.Name = "MathServiceWorkflow";
            activitybind3.Path = "divisor";
            workflowparameterbinding3.ParameterName = "divisor";
            workflowparameterbinding3.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding1);
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding2);
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding3);
            typedoperationinfo1.ContractType = typeof(SharedWorkflows.IMathService);
            typedoperationinfo1.Name = "DivideNumbers";
            this.receiveActivity1.ServiceOperationInfo = typedoperationinfo1;
            workflowserviceattributes1.ConfigurationName = "SharedWorkflows.MathServiceWorkflow";
            workflowserviceattributes1.Name = "MathServiceWorkflow";
            // 
            // MathServiceWorkflow
            // 
            this.Activities.Add(this.receiveActivity1);
            this.Name = "MathServiceWorkflow";
            this.SetValue(System.Workflow.Activities.ReceiveActivity.WorkflowServiceAttributesProperty, workflowserviceattributes1);
            this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity codeActivity1;
        private ReceiveActivity receiveActivity1;







    }
}
