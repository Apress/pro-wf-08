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
using System.ServiceModel;

namespace ConsoleServiceHost
{
    /// <summary>
    /// A console application that hosts the math workflow service
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowServiceHost serviceHost = null;
            try
            {
                //create an instance of the workflow service host
                serviceHost = new WorkflowServiceHost(
                    typeof(SharedWorkflows.MathServiceWorkflow));
                //we're open for business
                serviceHost.Open();

                if (serviceHost.Description.Endpoints.Count > 0)
                {
                    Console.WriteLine("Contract: {0}",
                        serviceHost.Description.Endpoints[0].Contract.ContractType);
                    Console.WriteLine("Endpoint: {0}",
                        serviceHost.Description.Endpoints[0].Address);
                }

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception hosting service: {0}",
                    exception.Message);
            }
            finally
            {
                try
                {
                    //close down the service host
                    if (serviceHost != null)
                    {
                        serviceHost.Close(new TimeSpan(0, 0, 10));
                    }
                }
                catch (CommunicationObjectFaultedException exception)
                {
                    Console.WriteLine(
                        "CommunicationObjectFaultedException on close: {0}",
                        exception.Message);
                }
                catch (TimeoutException exception)
                {
                    Console.WriteLine(
                        "TimeoutException on close: {0}",
                        exception.Message);
                }
            }
        }
    }
}
