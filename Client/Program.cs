using Client.CustomerServiceRef;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;

namespace Client
{
    /// <summary>
    /// Test client's program to call CustomerService
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerServiceClient _csClient = new CustomerServiceClient(new WSHttpBinding(), new EndpointAddress("http://localhost:51490/Services/CustomerService.svc"));

            try
            {
                // 1.Checks if there is a customer with a given customer number in the database
                Customer foundCustomer = _csClient.FindByCustomerNumber("3123123");
                if(foundCustomer != null)
                {
                    Console.WriteLine("The customer was found.");
                    Console.WriteLine("Name: {0}", foundCustomer.Name);
                    Console.WriteLine("Surname: {0}", foundCustomer.Surname);
                    Console.WriteLine("Phone number: {0}", foundCustomer.PhoneNumber);
                    Console.WriteLine("*******");
                }

                // 2.Gets all the customers from database
                List<Customer> customers = _csClient.GetAll().ToList();
                foreach(var customer in customers)
                {
                   Console.WriteLine("Name: {0}", customer.Name);
                   Console.WriteLine("Surname: {0}", customer.Surname);
                   Console.WriteLine("Phone number: {0}", customer.PhoneNumber);
                    Console.WriteLine("*******");
                }

                // 3.Creates and adds a new customer to the database
            
                Customer customerToAdd = new Customer
                {
                    Name = "Jan",
                    Surname = "Jarek",
                    CustomerNumber = DateTime.Now.Millisecond.ToString()
                };

                _csClient.AddCustomer(customerToAdd);
            }
            
            catch(DbUpdateException e)
            {
                Console.WriteLine("The given customer already exists in the database.");
                Console.WriteLine(e.ToString());
            }

            catch (TimeoutException timeProblem)
            {
                Console.WriteLine("The service operation timed out. " + timeProblem.Message);
                _csClient.Abort();
                Console.Read();
            }
            catch (CommunicationException commProblem)
            {
                Console.WriteLine("There was a communication problem. " + commProblem.Message);
                _csClient.Abort();
                Console.Read();
            }

            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occured.");
                Console.WriteLine(e.ToString());
            }

            
        }
    }
}
