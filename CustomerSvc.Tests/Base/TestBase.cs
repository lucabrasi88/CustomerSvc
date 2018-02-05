using CustomerSvc.Infrastructure;

namespace CustomerSvc.Tests.Base
{
    /// <summary>
    /// Class for setting preconditions for the purpose of tests
    /// </summary>
    public class TestBase
    {
        /// <summary>
        /// Creates new test database
        /// </summary>
        public void Setup()
        {
            CustomerInitializeTestDB customerDB = new CustomerInitializeTestDB();
            System.Data.Entity.Database.SetInitializer(customerDB);
        }
    }
}
