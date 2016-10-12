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
	partial class QueueGuessingGameWorkflow
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
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            this.terminateActivity1 = new System.Workflow.ComponentModel.TerminateActivity();
            this.delayActivity1 = new System.Workflow.Activities.DelayActivity();
            this.sendHintActivity2 = new SharedWorkflows.SendHintActivity();
            this.processGuessActivity1 = new SharedWorkflows.ProcessGuessActivity();
            this.eventDrivenActivity2 = new System.Workflow.Activities.EventDrivenActivity();
            this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
            this.listenActivity1 = new System.Workflow.Activities.ListenActivity();
            this.whileActivity1 = new System.Workflow.Activities.WhileActivity();
            this.sendHintActivity1 = new SharedWorkflows.SendHintActivity();
            // 
            // terminateActivity1
            // 
            this.terminateActivity1.Error = "You never made a guess";
            this.terminateActivity1.Name = "terminateActivity1";
            // 
            // delayActivity1
            // 
            this.delayActivity1.Name = "delayActivity1";
            this.delayActivity1.TimeoutDuration = System.TimeSpan.Parse("00:01:00");
            // 
            // sendHintActivity2
            // 
            activitybind1.Name = "QueueGuessingGameWorkflow";
            activitybind1.Path = "Message";
            this.sendHintActivity2.Name = "sendHintActivity2";
            this.sendHintActivity2.SetBinding(SharedWorkflows.SendHintActivity.MessageProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // processGuessActivity1
            // 
            activitybind2.Name = "QueueGuessingGameWorkflow";
            activitybind2.Path = "IsComplete";
            activitybind3.Name = "QueueGuessingGameWorkflow";
            activitybind3.Path = "Message";
            this.processGuessActivity1.Name = "processGuessActivity1";
            activitybind4.Name = "QueueGuessingGameWorkflow";
            activitybind4.Path = "TheNumber";
            this.processGuessActivity1.SetBinding(SharedWorkflows.ProcessGuessActivity.IsCompleteProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.processGuessActivity1.SetBinding(SharedWorkflows.ProcessGuessActivity.MessageProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.processGuessActivity1.SetBinding(SharedWorkflows.ProcessGuessActivity.TheNumberProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            // 
            // eventDrivenActivity2
            // 
            this.eventDrivenActivity2.Activities.Add(this.delayActivity1);
            this.eventDrivenActivity2.Activities.Add(this.terminateActivity1);
            this.eventDrivenActivity2.Name = "eventDrivenActivity2";
            // 
            // eventDrivenActivity1
            // 
            this.eventDrivenActivity1.Activities.Add(this.processGuessActivity1);
            this.eventDrivenActivity1.Activities.Add(this.sendHintActivity2);
            this.eventDrivenActivity1.Name = "eventDrivenActivity1";
            // 
            // listenActivity1
            // 
            this.listenActivity1.Activities.Add(this.eventDrivenActivity1);
            this.listenActivity1.Activities.Add(this.eventDrivenActivity2);
            this.listenActivity1.Name = "listenActivity1";
            // 
            // whileActivity1
            // 
            this.whileActivity1.Activities.Add(this.listenActivity1);
            ruleconditionreference1.ConditionName = "checkIsComplete";
            this.whileActivity1.Condition = ruleconditionreference1;
            this.whileActivity1.Name = "whileActivity1";
            // 
            // sendHintActivity1
            // 
            activitybind5.Name = "QueueGuessingGameWorkflow";
            activitybind5.Path = "Message";
            this.sendHintActivity1.Name = "sendHintActivity1";
            this.sendHintActivity1.SetBinding(SharedWorkflows.SendHintActivity.MessageProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // QueueGuessingGameWorkflow
            // 
            this.Activities.Add(this.sendHintActivity1);
            this.Activities.Add(this.whileActivity1);
            this.Name = "QueueGuessingGameWorkflow";
            this.Initialized += new System.EventHandler(this.OnInitialized);
            this.CanModifyActivities = false;

		}

		#endregion

        private SendHintActivity sendHintActivity1;
        private SendHintActivity sendHintActivity2;
        private ProcessGuessActivity processGuessActivity1;
        private TerminateActivity terminateActivity1;
        private DelayActivity delayActivity1;
        private EventDrivenActivity eventDrivenActivity2;
        private EventDrivenActivity eventDrivenActivity1;
        private ListenActivity listenActivity1;
        private WhileActivity whileActivity1;













































    }
}
