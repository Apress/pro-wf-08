using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
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
	partial class MathServiceStatefulWorkflow
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
            System.Workflow.Activities.WorkflowServiceAttributes workflowserviceattributes1 = new System.Workflow.Activities.WorkflowServiceAttributes();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.codeDivideNumbers = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.receiveStopWorkflow = new System.Workflow.Activities.ReceiveActivity();
            this.receiveGetLastQuotient = new System.Workflow.Activities.ReceiveActivity();
            this.receiveDivideNumbers = new System.Workflow.Activities.ReceiveActivity();
            this.receiveStartWorkflow = new System.Workflow.Activities.ReceiveActivity();
            this.eventStopWorkflow = new System.Workflow.Activities.EventDrivenActivity();
            this.eventGetLastQuotient = new System.Workflow.Activities.EventDrivenActivity();
            this.eventDivideNumbers = new System.Workflow.Activities.EventDrivenActivity();
            this.eventStartWorkflow = new System.Workflow.Activities.EventDrivenActivity();
            this.StartedState = new System.Workflow.Activities.StateActivity();
            this.CompletedState = new System.Workflow.Activities.StateActivity();
            this.WaitingForStartupState = new System.Workflow.Activities.StateActivity();
            // 
            // setStateActivity2
            // 
            this.setStateActivity2.Name = "setStateActivity2";
            this.setStateActivity2.TargetStateName = "CompletedState";
            // 
            // codeDivideNumbers
            // 
            this.codeDivideNumbers.Name = "codeDivideNumbers";
            this.codeDivideNumbers.ExecuteCode += new System.EventHandler(this.codeDivideNumbers_ExecuteCode);
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "StartedState";
            // 
            // receiveStopWorkflow
            // 
            this.receiveStopWorkflow.Activities.Add(this.setStateActivity2);
            this.receiveStopWorkflow.Name = "receiveStopWorkflow";
            typedoperationinfo1.ContractType = typeof(SharedWorkflows.IMathServiceStateful);
            typedoperationinfo1.Name = "StopWorkflow";
            this.receiveStopWorkflow.ServiceOperationInfo = typedoperationinfo1;
            // 
            // receiveGetLastQuotient
            // 
            this.receiveGetLastQuotient.Name = "receiveGetLastQuotient";
            activitybind1.Name = "MathServiceStatefulWorkflow";
            activitybind1.Path = "quotient";
            workflowparameterbinding1.ParameterName = "(ReturnValue)";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.receiveGetLastQuotient.ParameterBindings.Add(workflowparameterbinding1);
            typedoperationinfo2.ContractType = typeof(SharedWorkflows.IMathServiceStateful);
            typedoperationinfo2.Name = "GetLastQuotient";
            this.receiveGetLastQuotient.ServiceOperationInfo = typedoperationinfo2;
            // 
            // receiveDivideNumbers
            // 
            this.receiveDivideNumbers.Activities.Add(this.codeDivideNumbers);
            this.receiveDivideNumbers.Name = "receiveDivideNumbers";
            activitybind2.Name = "MathServiceStatefulWorkflow";
            activitybind2.Path = "quotient";
            workflowparameterbinding2.ParameterName = "(ReturnValue)";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            activitybind3.Name = "MathServiceStatefulWorkflow";
            activitybind3.Path = "dividend";
            workflowparameterbinding3.ParameterName = "dividend";
            workflowparameterbinding3.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            activitybind4.Name = "MathServiceStatefulWorkflow";
            activitybind4.Path = "divisor";
            workflowparameterbinding4.ParameterName = "divisor";
            workflowparameterbinding4.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.receiveDivideNumbers.ParameterBindings.Add(workflowparameterbinding2);
            this.receiveDivideNumbers.ParameterBindings.Add(workflowparameterbinding3);
            this.receiveDivideNumbers.ParameterBindings.Add(workflowparameterbinding4);
            typedoperationinfo3.ContractType = typeof(SharedWorkflows.IMathServiceStateful);
            typedoperationinfo3.Name = "DivideNumbers";
            this.receiveDivideNumbers.ServiceOperationInfo = typedoperationinfo3;
            // 
            // receiveStartWorkflow
            // 
            this.receiveStartWorkflow.Activities.Add(this.setStateActivity1);
            this.receiveStartWorkflow.CanCreateInstance = true;
            this.receiveStartWorkflow.Name = "receiveStartWorkflow";
            typedoperationinfo4.ContractType = typeof(SharedWorkflows.IMathServiceStateful);
            typedoperationinfo4.Name = "StartWorkflow";
            this.receiveStartWorkflow.ServiceOperationInfo = typedoperationinfo4;
            // 
            // eventStopWorkflow
            // 
            this.eventStopWorkflow.Activities.Add(this.receiveStopWorkflow);
            this.eventStopWorkflow.Name = "eventStopWorkflow";
            // 
            // eventGetLastQuotient
            // 
            this.eventGetLastQuotient.Activities.Add(this.receiveGetLastQuotient);
            this.eventGetLastQuotient.Name = "eventGetLastQuotient";
            // 
            // eventDivideNumbers
            // 
            this.eventDivideNumbers.Activities.Add(this.receiveDivideNumbers);
            this.eventDivideNumbers.Name = "eventDivideNumbers";
            // 
            // eventStartWorkflow
            // 
            this.eventStartWorkflow.Activities.Add(this.receiveStartWorkflow);
            this.eventStartWorkflow.Name = "eventStartWorkflow";
            // 
            // StartedState
            // 
            this.StartedState.Activities.Add(this.eventDivideNumbers);
            this.StartedState.Activities.Add(this.eventGetLastQuotient);
            this.StartedState.Activities.Add(this.eventStopWorkflow);
            this.StartedState.Name = "StartedState";
            // 
            // CompletedState
            // 
            this.CompletedState.Name = "CompletedState";
            // 
            // WaitingForStartupState
            // 
            this.WaitingForStartupState.Activities.Add(this.eventStartWorkflow);
            this.WaitingForStartupState.Name = "WaitingForStartupState";
            workflowserviceattributes1.ConfigurationName = "Workflow1";
            workflowserviceattributes1.Name = "Workflow1";
            // 
            // MathServiceStatefulWorkflow
            // 
            this.Activities.Add(this.WaitingForStartupState);
            this.Activities.Add(this.CompletedState);
            this.Activities.Add(this.StartedState);
            this.CompletedStateName = "CompletedState";
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "WaitingForStartupState";
            this.Name = "MathServiceStatefulWorkflow";
            this.SetValue(System.Workflow.Activities.ReceiveActivity.WorkflowServiceAttributesProperty, workflowserviceattributes1);
            this.CanModifyActivities = false;

		}

		#endregion

        private ReceiveActivity receiveGetLastQuotient;
        private SetStateActivity setStateActivity2;
        private ReceiveActivity receiveStopWorkflow;
        private CodeActivity codeDivideNumbers;
        private ReceiveActivity receiveStartWorkflow;
        private EventDrivenActivity eventStartWorkflow;
        private StateActivity StartedState;
        private SetStateActivity setStateActivity1;
        private EventDrivenActivity eventDivideNumbers;
        private EventDrivenActivity eventStopWorkflow;
        private EventDrivenActivity eventGetLastQuotient;
        private ReceiveActivity receiveDivideNumbers;
        private StateActivity CompletedState;
        private StateActivity WaitingForStartupState;



























    }
}
