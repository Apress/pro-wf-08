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
using System.ComponentModel;
using System.Workflow.ComponentModel;

namespace SharedWorkflows
{
    /// <summary>
    /// Provides the Priority attached property at design time
    /// </summary>
    [ProvideProperty("Priority", typeof(Activity))]
    public class PriorityExtenderProvider : IExtenderProvider
    {
        #region IExtenderProvider Members

        public bool CanExtend(object extendee)
        {
            Boolean result = false;
            Activity activity = extendee as Activity;
            if (activity != null)
            {
                result = (activity.Parent != null &&
                          activity.Parent is SequencePriorityActivity);
            }
            return result;
        }

        #endregion

        [Description("Activities with higher numbers are executed first")]
        public Int32 GetPriority(Activity activity)
        {
            return (Int32)activity.GetValue(
                SequencePriorityActivity.PriorityProperty);
        }

        public void SetPriority(Activity activity, Int32 propValue)
        {
            activity.SetValue(
                SequencePriorityActivity.PriorityProperty, propValue);
        }
    }
}
