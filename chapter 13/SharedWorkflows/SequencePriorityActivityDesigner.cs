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
using System.ComponentModel.Design;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;

namespace SharedWorkflows
{
    /// <summary>
    /// A custom designer for the SequencePriorityActivity
    /// </summary>
    public class SequencePriorityActivityDesigner : SequenceDesigner
    {
        protected override void Initialize(Activity activity)
        {
            base.Initialize(activity);

            //see if the Priority provider has already been added
            IExtenderListService list
                = GetService(typeof(IExtenderListService))
                    as IExtenderListService;
            Boolean isAlreadyAdded = false;
            foreach (IExtenderProvider provider
                in list.GetExtenderProviders())
            {
                if (provider is PriorityExtenderProvider)
                {
                    isAlreadyAdded = true;
                    break;
                }
            }

            //Add the custom extender provider if it doesn't already exist
            if (!isAlreadyAdded)
            {
                IExtenderProviderService service
                    = GetService(typeof(IExtenderProviderService))
                        as IExtenderProviderService;
                if (service != null)
                {
                    service.AddExtenderProvider(new PriorityExtenderProvider());
                }
            }
        }
    }
}
