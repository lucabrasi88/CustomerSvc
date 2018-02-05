using CustomerSvc.Core;
using System.Data.Entity;

namespace CustomerSvc.Infrastructure
{
    /// <summary>
    /// Class for DbContext
    /// </summary>
    public class CustomerContext : DbContext
    {
        public CustomerContext()
           : base("name=CustomersAppConnectionString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
