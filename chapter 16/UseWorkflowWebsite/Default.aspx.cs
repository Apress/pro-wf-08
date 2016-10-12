//--------------------------------------------------------------------------------
// This file is part of the downloadable code for the Apress book:
// Pro WF: Windows Workflow in .NET 3.5
// Copyright (c) Bruce Bukovics.  All rights reserved.
//
// This code is provided as is without warranty of any kind, either expressed
// or implied, including but not limited to fitness for any particular purpose. 
// You may use the code for any commercial or noncommercial purpose, and combine 
// it with your own code, but cannot reproduce it in whole or in part for 
// publication purposes without prior approval. 
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;

using SharedWorkflows;

public partial class _Default : System.Web.UI.Page
{
    /// <summary>
    /// The calculate button was pressed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        //retrieve the workflow runtime
        WorkflowRuntime workflowRuntime
            = Application["WorkflowRuntime"] as WorkflowRuntime;
        //retrieve the scheduler that is used to execute workflows
        ManualWorkflowSchedulerService scheduler =
            workflowRuntime.GetService(
                typeof(ManualWorkflowSchedulerService))
                    as ManualWorkflowSchedulerService;

        //handle the WorkflowCompleted event in order to 
        //retrieve the output parameters from the completed workflow
        workflowRuntime.WorkflowCompleted
            += new EventHandler<WorkflowCompletedEventArgs>(
                workflowRuntime_WorkflowCompleted);

        //get the input parameters
        Double dividendValue;
        Double divisorValue;
        Double.TryParse(dividend.Text, out dividendValue);
        Double.TryParse(divisor.Text, out divisorValue);

        //pass the input parameters to the workflow
        Dictionary<String, Object> wfArguments
            = new Dictionary<string, object>();
        wfArguments.Add("Dividend", dividendValue);
        wfArguments.Add("Divisor", divisorValue);

        //create and start the workflow
        WorkflowInstance instance = workflowRuntime.CreateWorkflow(
            typeof(SharedWorkflows.DivideNumbersWorkflow), wfArguments);
        instance.Start();

        //execute the workflow synchronously on our thread
        scheduler.RunWorkflow(instance.InstanceId);
    }

    /// <summary>
    /// The workflow has completed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void workflowRuntime_WorkflowCompleted(
        object sender, WorkflowCompletedEventArgs e)
    {
        //get the result from the workflow
        if (e.OutputParameters.ContainsKey("Quotient"))
        {
            Double quotientValue
                = (Double)e.OutputParameters["Quotient"];
            quotient.Text = quotientValue.ToString();
        }
    }
}