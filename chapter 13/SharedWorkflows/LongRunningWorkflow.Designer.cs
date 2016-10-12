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
	partial class LongRunningWorkflow
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
            this.longRunningActivity3 = new SharedWorkflows.LongRunningActivity();
            this.longRunningActivity2 = new SharedWorkflows.LongRunningActivity();
            this.longRunningActivity1 = new SharedWorkflows.LongRunningActivity();
            this.sequenceActivity3 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity2 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity1 = new System.Workflow.Activities.SequenceActivity();
            this.parallelActivity1 = new System.Workflow.Activities.ParallelActivity();
            // 
            // longRunningActivity3
            // 
            this.longRunningActivity3.Name = "longRunningActivity3";
            this.longRunningActivity3.WorkData = "Three";
            // 
            // longRunningActivity2
            // 
            this.longRunningActivity2.Name = "longRunningActivity2";
            this.longRunningActivity2.WorkData = "Two";
            // 
            // longRunningActivity1
            // 
            this.longRunningActivity1.Name = "longRunningActivity1";
            this.longRunningActivity1.WorkData = "One";
            // 
            // sequenceActivity3
            // 
            this.sequenceActivity3.Activities.Add(this.longRunningActivity3);
            this.sequenceActivity3.Name = "sequenceActivity3";
            // 
            // sequenceActivity2
            // 
            this.sequenceActivity2.Activities.Add(this.longRunningActivity2);
            this.sequenceActivity2.Name = "sequenceActivity2";
            // 
            // sequenceActivity1
            // 
            this.sequenceActivity1.Activities.Add(this.longRunningActivity1);
            this.sequenceActivity1.Name = "sequenceActivity1";
            // 
            // parallelActivity1
            // 
            this.parallelActivity1.Activities.Add(this.sequenceActivity1);
            this.parallelActivity1.Activities.Add(this.sequenceActivity2);
            this.parallelActivity1.Activities.Add(this.sequenceActivity3);
            this.parallelActivity1.Name = "parallelActivity1";
            // 
            // LongRunningWorkflow
            // 
            this.Activities.Add(this.parallelActivity1);
            this.Name = "LongRunningWorkflow";
            this.CanModifyActivities = false;

		}

		#endregion

        private LongRunningActivity longRunningActivity3;
        private LongRunningActivity longRunningActivity2;
        private SequenceActivity sequenceActivity3;
        private SequenceActivity sequenceActivity2;
        private SequenceActivity sequenceActivity1;
        private ParallelActivity parallelActivity1;
        private LongRunningActivity longRunningActivity1;


    }
}
