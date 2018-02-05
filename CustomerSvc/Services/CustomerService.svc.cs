using System.Collections.Generic;
using System.ServiceModel;
using CustomerSvc.Core;
using CustomerSvc.Core.Interfaces;
using CustomerSvc.Infrastructure;

namespace CustomerSvc
{
    /// <summary>
    /// ICustomerService's implementation.
    /// Contains exposed methods for managing customers' data.
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        /// <summary>
        /// Adds a new customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerNumber"></param>
        public void DeleteCustomer(int customerNumber)
        {
            _customerRepository.Delete(customerNumber);
        }

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customerNumber"></param>
        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Update(customer);
        }

        /// <summary>
        /// Finds an existing customer with a given customer's number
        /// </summary>
        /// <param name="customerNumber">Customer's number</param>
        /// <returns>Customer</returns>
        public Customer FindByCustomerNumber(string customerNumber)
        {
            return _customerRepository.FindByCustomerNumber(customerNumber);
        }

        /// <summary>
        /// Gets all the customers
        /// </summary>
        /// <returns>The list of customers</returns>
        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
    }
}
