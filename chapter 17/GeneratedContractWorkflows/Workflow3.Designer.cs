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
	partial class Workflow3
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
            System.Workflow.Activities.OperationInfo operationinfo1 = new System.Workflow.Activities.OperationInfo();
            System.Workflow.Activities.OperationParameterInfo operationparameterinfo1 = new System.Workflow.Activities.OperationParameterInfo();
            System.Workflow.Activities.OperationInfo operationinfo2 = new System.Workflow.Activities.OperationInfo();
            System.Workflow.Activities.OperationParameterInfo operationparameterinfo2 = new System.Workflow.Activities.OperationParameterInfo();
            System.Workflow.Activities.OperationParameterInfo operationparameterinfo3 = new System.Workflow.Activities.OperationParameterInfo();
            System.Workflow.Activities.WorkflowServiceAttributes workflowserviceattributes1 = new System.Workflow.Activities.WorkflowServiceAttributes();
            this.receiveActivity2 = new System.Workflow.Activities.ReceiveActivity();
            this.receiveActivity1 = new System.Workflow.Activities.ReceiveActivity();
            // 
            // receiveActivity2
            // 
            this.receiveActivity2.Name = "receiveActivity2";
            operationinfo1.ContractName = "MyServiceContract";
            operationinfo1.Name = "Operation1";
            operationparameterinfo1.Attributes = ((System.Reflection.ParameterAttributes)((System.Reflection.ParameterAttributes.Out | System.Reflection.ParameterAttributes.Retval)));
            operationparameterinfo1.Name = "(ReturnValue)";
            operationparameterinfo1.ParameterType = typeof(bool);
            operationparameterinfo1.Position = -1;
            operationinfo1.Parameters.Add(operationparameterinfo1);
            this.receiveActivity2.ServiceOperationInfo = operationinfo1;
            // 
            // receiveActivity1
            // 
            this.receiveActivity1.Name = "receiveActivity1";
            operationinfo2.ContractName = "MyServiceContract";
            operationinfo2.Name = "DoSomething";
            operationparameterinfo2.Attributes = ((System.Reflection.ParameterAttributes)((System.Reflection.ParameterAttributes.Out | System.Reflection.ParameterAttributes.Retval)));
            operationparameterinfo2.Name = "(ReturnValue)";
            operationparameterinfo2.ParameterType = typeof(string);
            operationparameterinfo2.Position = -1;
            operationparameterinfo3.Attributes = System.Reflection.ParameterAttributes.In;
            operationparameterinfo3.Name = "param1";
            operationparameterinfo3.ParameterType = typeof(int);
            operationparameterinfo3.Position = 0;
            operationinfo2.Parameters.Add(operationparameterinfo2);
            operationinfo2.Parameters.Add(operationparameterinfo3);
            this.receiveActivity1.ServiceOperationInfo = operationinfo2;
            workflowserviceattributes1.ConfigurationName = "GeneratedContractWorkflows.Workflow3";
            workflowserviceattributes1.Name = "Workflow3";
            // 
            // Workflow3
            // 
            this.Activities.Add(this.receiveActivity1);
            this.Activities.Add(this.receiveActivity2);
            this.Name = "Workflow3";
            this.SetValue(System.Workflow.Activities.ReceiveActivity.WorkflowServiceAttributesProperty, workflowserviceattributes1);
            this.CanModifyActivities = false;

		}

		#endregion

        private ReceiveActivity receiveActivity2;
        private ReceiveActivity receiveActivity1;




    }
}
