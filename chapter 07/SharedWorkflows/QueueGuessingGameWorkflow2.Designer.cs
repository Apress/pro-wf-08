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
	partial class QueueGuessingGameWorkflow2
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
            this.sendHintActivity2 = new SharedWorkflows.SendHintActivity();
            this.processGuessActivity1 = new SharedWorkflows.ProcessGuessActivity();
            this.sequenceActivity1 = new System.Workflow.Activities.SequenceActivity();
            this.whileActivity1 = new System.Workflow.Activities.WhileActivity();
            this.sendHintActivity1 = new SharedWorkflows.SendHintActivity();
            // 
            // sendHintActivity2
            // 
            activitybind1.Name = "QueueGuessingGameWorkflow2";
            activitybind1.Path = "Message";
            this.sendHintActivity2.Name = "sendHintActivity2";
            this.sendHintActivity2.SetBinding(SharedWorkflows.SendHintActivity.MessageProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // processGuessActivity1
            // 
            activitybind2.Name = "QueueGuessingGameWorkflow2";
            activitybind2.Path = "IsComplete";
            activitybind3.Name = "QueueGuessingGameWorkflow2";
            activitybind3.Path = "Message";
            this.processGuessActivity1.Name = "processGuessActivity1";
            activitybind4.Name = "QueueGuessingGameWorkflow2";
            activitybind4.Path = "TheNumber";
            this.processGuessActivity1.SetBinding(SharedWorkflows.ProcessGuessActivity.IsCompleteProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.processGuessActivity1.SetBinding(SharedWorkflows.ProcessGuessActivity.MessageProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.processGuessActivity1.SetBinding(SharedWorkflows.ProcessGuessActivity.TheNumberProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            // 
            // sequenceActivity1
            // 
            this.sequenceActivity1.Activities.Add(this.processGuessActivity1);
            this.sequenceActivity1.Activities.Add(this.sendHintActivity2);
            this.sequenceActivity1.Name = "sequenceActivity1";
            // 
            // whileActivity1
            // 
            this.whileActivity1.Activities.Add(this.sequenceActivity1);
            ruleconditionreference1.ConditionName = "checkIsComplete";
            this.whileActivity1.Condition = ruleconditionreference1;
            this.whileActivity1.Name = "whileActivity1";
            // 
            // sendHintActivity1
            // 
            activitybind5.Name = "QueueGuessingGameWorkflow2";
            activitybind5.Path = "Message";
            this.sendHintActivity1.Name = "sendHintActivity1";
            this.sendHintActivity1.SetBinding(SharedWorkflows.SendHintActivity.MessageProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // QueueGuessingGameWorkflow2
            // 
            this.Activities.Add(this.sendHintActivity1);
            this.Activities.Add(this.whileActivity1);
            this.Name = "QueueGuessingGameWorkflow2";
            this.Initialized += new System.EventHandler(this.OnInitialized);
            this.CanModifyActivities = false;

		}

		#endregion

        private SendHintActivity sendHintActivity1;
        private SendHintActivity sendHintActivity2;
        private SequenceActivity sequenceActivity1;
        private ProcessGuessActivity processGuessActivity1;
        private WhileActivity whileActivity1;















































    }
}
