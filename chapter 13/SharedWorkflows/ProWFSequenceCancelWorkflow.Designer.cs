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
	partial class ProWFSequenceCancelWorkflow
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
            this.delayActivity3 = new System.Workflow.Activities.DelayActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.throwActivity1 = new System.Workflow.ComponentModel.ThrowActivity();
            this.delayActivity1 = new System.Workflow.Activities.DelayActivity();
            this.proWFSequenceActivity1 = new SharedWorkflows.ProWFSequenceActivity();
            this.delayActivity2 = new System.Workflow.Activities.DelayActivity();
            this.sequenceActivity2 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity1 = new System.Workflow.Activities.SequenceActivity();
            this.parallelActivity1 = new System.Workflow.Activities.ParallelActivity();
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.codeActivity3_ExecuteCode);
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.codeActivity2_ExecuteCode);
            // 
            // delayActivity3
            // 
            this.delayActivity3.Name = "delayActivity3";
            this.delayActivity3.TimeoutDuration = System.TimeSpan.Parse("00:00:02");
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            // 
            // throwActivity1
            // 
            this.throwActivity1.FaultType = typeof(System.IO.InvalidDataException);
            this.throwActivity1.Name = "throwActivity1";
            // 
            // delayActivity1
            // 
            this.delayActivity1.Name = "delayActivity1";
            this.delayActivity1.TimeoutDuration = System.TimeSpan.Parse("00:00:01");
            // 
            // proWFSequenceActivity1
            // 
            this.proWFSequenceActivity1.Activities.Add(this.codeActivity1);
            this.proWFSequenceActivity1.Activities.Add(this.delayActivity3);
            this.proWFSequenceActivity1.Activities.Add(this.codeActivity2);
            this.proWFSequenceActivity1.Activities.Add(this.codeActivity3);
            this.proWFSequenceActivity1.Name = "proWFSequenceActivity1";
            // 
            // delayActivity2
            // 
            this.delayActivity2.Name = "delayActivity2";
            this.delayActivity2.TimeoutDuration = System.TimeSpan.Parse("00:00:01");
            // 
            // sequenceActivity2
            // 
            this.sequenceActivity2.Activities.Add(this.delayActivity1);
            this.sequenceActivity2.Activities.Add(this.throwActivity1);
            this.sequenceActivity2.Name = "sequenceActivity2";
            // 
            // sequenceActivity1
            // 
            this.sequenceActivity1.Activities.Add(this.delayActivity2);
            this.sequenceActivity1.Activities.Add(this.proWFSequenceActivity1);
            this.sequenceActivity1.Name = "sequenceActivity1";
            // 
            // parallelActivity1
            // 
            this.parallelActivity1.Activities.Add(this.sequenceActivity1);
            this.parallelActivity1.Activities.Add(this.sequenceActivity2);
            this.parallelActivity1.Name = "parallelActivity1";
            // 
            // ProWFSequenceWorkflow
            // 
            this.Activities.Add(this.parallelActivity1);
            this.Name = "ProWFSequenceWorkflow";
            this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity codeActivity3;
        private CodeActivity codeActivity2;
        private CodeActivity codeActivity1;
        private ThrowActivity throwActivity1;
        private DelayActivity delayActivity1;
        private SequenceActivity sequenceActivity2;
        private SequenceActivity sequenceActivity1;
        private ParallelActivity parallelActivity1;
        private DelayActivity delayActivity2;
        private DelayActivity delayActivity3;
        private ProWFSequenceActivity proWFSequenceActivity1;





















    }
}
