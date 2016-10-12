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

namespace GeneratedContractWorkflows
{
	partial class Workflow2
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
            System.Workflow.Activities.OperationInfo operationinfo1 = new System.Workflow.Activities.OperationInfo();
            System.Workflow.Activities.OperationParameterInfo operationparameterinfo1 = new System.Workflow.Activities.OperationParameterInfo();
            System.Workflow.Activities.OperationParameterInfo operationparameterinfo2 = new System.Workflow.Activities.OperationParameterInfo();
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
            activitybind1.Name = "Workflow2";
            activitybind1.Path = "Param1";
            workflowparameterbinding1.ParameterName = "param1";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            activitybind2.Name = "Workflow2";
            activitybind2.Path = "ReturnValue";
            workflowparameterbinding2.ParameterName = "(ReturnValue)";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding1);
            this.receiveActivity1.ParameterBindings.Add(workflowparameterbinding2);
            operationinfo1.ContractName = "IGeneratedContract";
            operationinfo1.Name = "DoSomething";
            operationparameterinfo1.Attributes = ((System.Reflection.ParameterAttributes)((System.Reflection.ParameterAttributes.Out | System.Reflection.ParameterAttributes.Retval)));
            operationparameterinfo1.Name = "(ReturnValue)";
            operationparameterinfo1.ParameterType = typeof(string);
            operationparameterinfo1.Position = -1;
            operationparameterinfo2.Attributes = System.Reflection.ParameterAttributes.In;
            operationparameterinfo2.Name = "param1";
            operationparameterinfo2.ParameterType = typeof(int);
            operationparameterinfo2.Position = 0;
            operationinfo1.Parameters.Add(operationparameterinfo1);
            operationinfo1.Parameters.Add(operationparameterinfo2);
            this.receiveActivity1.ServiceOperationInfo = operationinfo1;
            workflowserviceattributes1.ConfigurationName = "GeneratedContractWorkflows.Workflow2";
            workflowserviceattributes1.Name = "Workflow2";
            // 
            // Workflow2
            // 
            this.Activities.Add(this.receiveActivity1);
            this.Name = "Workflow2";
            this.SetValue(System.Workflow.Activities.ReceiveActivity.WorkflowServiceAttributesProperty, workflowserviceattributes1);
            this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity codeActivity1;
        private ReceiveActivity receiveActivity1;








    }
}
