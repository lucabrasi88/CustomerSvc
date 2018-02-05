using CustomerSvc.Core;
using System.Data.Entity;

namespace CustomerSvc.Infrastructure
{
    /// <summary>
    /// Initializes new database for the purpose of tests
    /// </summary>
    public class CustomerInitializeTestDB : DropCreateDatabaseAlways<CustomerContext>
    {
        /// <summary>
        /// Creates entities to start with
        /// </summary>
        /// <param name="context">Customer database context</param>
        protected override void Seed(CustomerContext context)
        {
            context.Customers.Add(new Customer { Id = 1, Name = "Lukasz", Surname = "Czaczyk", PhoneNumber = "48111222333", Address = "Szkolna 14, 65-500 Nibylandia", CustomerNumber = "LC1" });
            context.Customers.Add(new Customer { Id = 2, Name = "Krzysztof", Surname = "Kowalski", PhoneNumber = "4831415161", Address = "Główna 19, 65-500 Nibylandia", CustomerNumber = "KK1" });
            context.SaveChanges(); base.Seed(context); 
        }
    }
} 

