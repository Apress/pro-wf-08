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
using ConsoleStatefulMathClient.MathService;

namespace ConsoleStatefulMathClient
{
    /// <summary>
    /// A client application for the Math workflow service
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //create two client instances
                MathServiceStatefulClient client1
                    = new MathServiceStatefulClient();
                MathServiceStatefulClient client2
                    = new MathServiceStatefulClient();

                Console.WriteLine("Server endpoint: {0}",
                    client1.Endpoint.Address.ToString());

                //start both instances
                client1.StartWorkflow();
                client2.StartWorkflow();

                //perform division using the 1st instance
                Double quotient = client1.GetLastQuotient();
                Console.WriteLine(
                    "Client 1 Quotient prior to division: {0}", quotient);

                quotient = client1.DivideNumbers(333, 3);
                Console.WriteLine(
                    "Client 1 Quotient from DivideNumber: {0}", quotient);

                quotient = client1.GetLastQuotient();
                Console.WriteLine(
                    "Client 1 Quotient from GetLastQuotient: {0}", quotient);

                //perform division using the 2nd instance
                quotient = client2.GetLastQuotient();
                Console.WriteLine(
                    "Client 2 Quotient prior to division: {0}", quotient);

                quotient = client2.DivideNumbers(10, 2);
                Console.WriteLine(
                    "Client 2 Quotient from DivideNumber: {0}", quotient);

                quotient = client2.GetLastQuotient();
                Console.WriteLine(
                    "Client 2 Quotient from GetLastQuotient: {0}", quotient);

                //stop both instances
                client1.StopWorkflow();
                client1.Close();

                client2.StopWorkflow();
                client2.Close();
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
