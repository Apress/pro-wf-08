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
	partial class SequencePriorityWorkflow
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
            this.codeActivity3 = new System.Workflow.Activities.CodeActivity();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.sequencePriorityActivity1 = new SharedWorkflows.SequencePriorityActivity();
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.codeActivity3_ExecuteCode);
            this.codeActivity3.SetValue(SharedWorkflows.SequencePriorityActivity.PriorityProperty, 50);
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.codeActivity2_ExecuteCode);
            this.codeActivity2.SetValue(SharedWorkflows.SequencePriorityActivity.PriorityProperty, 100);
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            this.codeActivity1.SetValue(SharedWorkflows.SequencePriorityActivity.PriorityProperty, 0);
            // 
            // sequencePriorityActivity1
            // 
            this.sequencePriorityActivity1.Activities.Add(this.codeActivity1);
            this.sequencePriorityActivity1.Activities.Add(this.codeActivity2);
            this.sequencePriorityActivity1.Activities.Add(this.codeActivity3);
            this.sequencePriorityActivity1.Name = "sequencePriorityActivity1";
            // 
            // SequencePriorityWorkflow
            // 
            this.Activities.Add(this.sequencePriorityActivity1);
            this.Name = "SequencePriorityWorkflow";
            this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity codeActivity3;
        private CodeActivity codeActivity2;
        private CodeActivity codeActivity1;
        private SequencePriorityActivity sequencePriorityActivity1;











    }
}
