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
using ConsoleMathServiceClient.MathService;

namespace ConsoleMathServiceClient
{
    class Program
    {
        /// <summary>
        /// Access the MathServiceWorkflow service
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                //create an instance of the client proxy
                MathServiceClient client = new MathServiceClient();

                Console.WriteLine("Server endpoint: {0}",
                    client.Endpoint.Address.ToString());

                //call the service
                Double quotient = client.DivideNumbers(333, 3);
                Console.WriteLine(
                    "Result of division 333 / 3: {0}", quotient);

                client.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Unhandled exception: {0} - {1}",
                    exception.GetType().Name, exception.Message);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
