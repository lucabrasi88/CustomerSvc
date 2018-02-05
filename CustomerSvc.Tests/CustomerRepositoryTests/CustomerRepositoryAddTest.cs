using CustomerSvc.Tests.Base;
using NUnit.Framework;
using CustomerSvc.Core;
using CustomerSvc.Infrastructure;
using System.Linq;

namespace CustomerSvc.Tests
{
    [TestFixture]
    public class CustomerRepositoryAddTest : TestBase
    {
        private int _entitiesAmount;
        private CustomerRepository _customerRepository;

        [SetUp]
        public void Initialize()
        {
            Arrange();
            Act();
        }

        private void Arrange()
        {
            Setup();
            _customerRepository = new CustomerRepository();
        }

        private void Act()
        {
            Customer customerToAdd = new Customer
            {
                Id = 3,
                Name = "Jan",
                Surname = "Janek",
                CustomerNumber = "JJ1"
            };

            _customerRepository.Add(customerToAdd);
            _entitiesAmount = _customerRepository.GetAll().ToList().Count();
        }

        [Test]
        public void IsNewRecordAdded_Success()
        {
            Assert.AreEqual(3, _entitiesAmount);
        }
    }
}
