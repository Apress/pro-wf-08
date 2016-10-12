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
using System.Threading;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Workflow.Runtime;

using ConsoleInventoryHost;

namespace ConsoleInventoryClient
{
    /// <summary>
    /// Execute the InventoryClientWorkflow
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent waitEvent = new AutoResetEvent(false);
            WorkflowServiceHost serviceHost = null;
            try
            {
                //create an instance of the workflow service host
                serviceHost = new WorkflowServiceHost(
                    typeof(ConsoleInventoryClient.InventoryClientWorkflow));

                //get the service behavior that represents the WF runtime
                WorkflowRuntimeBehavior runtime =
                    serviceHost.Description.Behaviors.Find
                        <WorkflowRuntimeBehavior>();
                runtime.WorkflowRuntime.WorkflowCompleted
                    += delegate(object sender, WorkflowCompletedEventArgs e)
                    {
                        List<Product> products
                            = e.OutputParameters["Products"] as List<Product>;

                        if (products != null)
                        {
                            Console.WriteLine("{0} products returned",
                                products.Count);
                            foreach (Product p in products)
                            {
                                Console.WriteLine(
                                    "Product {0}, size {1}, inventory {2}",
                                    p.Id, p.Size, p.Inventory);
                            }
                        }

                        Console.WriteLine("WorkflowCompleted");
                        waitEvent.Set();
                    };
                runtime.WorkflowRuntime.WorkflowTerminated
                    += delegate(object sender, WorkflowTerminatedEventArgs e)
                    {
                        Console.WriteLine("WorkflowTerminated: "
                            + e.Exception.Message);
                    };

                //begin hosting return calls from the inventory service
                serviceHost.Open();

                if (serviceHost.Description.Endpoints.Count > 0)
                {
                    Console.WriteLine("Contract: {0}",
                        serviceHost.Description.Endpoints[0].Contract.ContractType);
                    Console.WriteLine("Endpoint: {0}",
                        serviceHost.Description.Endpoints[0].Address);
                }

                //start an instance of the client workflow
                Console.WriteLine("\r\nWorkflow started for 1001");
                Dictionary<String, Object> parameters
                    = new Dictionary<string, object>();
                parameters.Add("Id", 1001);
                WorkflowInstance instance =
                    runtime.WorkflowRuntime.CreateWorkflow(
                        typeof(InventoryClientWorkflow), parameters);
                instance.Start();
                //wait for the workflow instance to complete
                waitEvent.WaitOne(5000, false);
                Console.WriteLine("Workflow ended for 1001");

                //start another instance 
                Console.WriteLine("\r\nWorkflow started for 2002");
                parameters = new Dictionary<string, object>();
                parameters.Add("Id", 2002);
                instance = runtime.WorkflowRuntime.CreateWorkflow(
                        typeof(InventoryClientWorkflow), parameters);
                instance.Start();
                waitEvent.WaitOne(5000, false);
                Console.WriteLine("Workflow ended for 2002");

                //and one more instance
                Console.WriteLine("\r\nWorkflow started for 3003");
                parameters = new Dictionary<string, object>();
                parameters.Add("Id", 3003);
                instance = runtime.WorkflowRuntime.CreateWorkflow(
                        typeof(InventoryClientWorkflow), parameters);
                instance.Start();
                waitEvent.WaitOne(5000, false);
                Console.WriteLine("Workflow ended for 3003");

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
