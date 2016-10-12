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
	partial class FitForPurposeWorkflow
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
            this.fitForPurposeActivity2 = new SharedWorkflows.FitForPurposeActivity();
            this.fitForPurposeActivity1 = new SharedWorkflows.FitForPurposeActivity();
            // 
            // fitForPurposeActivity2
            // 
            this.fitForPurposeActivity2.Name = "fitForPurposeActivity2";
            this.fitForPurposeActivity2.TestValue = "Two";
            // 
            // fitForPurposeActivity1
            // 
            this.fitForPurposeActivity1.Name = "fitForPurposeActivity1";
            this.fitForPurposeActivity1.TestValue = "One";
            // 
            // FitForPurposeWorkflow
            // 
            this.Activities.Add(this.fitForPurposeActivity1);
            this.Activities.Add(this.fitForPurposeActivity2);
            this.Name = "FitForPurposeWorkflow";
            this.CanModifyActivities = false;

		}

		#endregion

        private FitForPurposeActivity fitForPurposeActivity2;
        private FitForPurposeActivity fitForPurposeActivity1;

    }
}
