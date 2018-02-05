using System.Collections.Generic;
using System.Linq;
using CustomerSvc.Core;
using CustomerSvc.Core.Interfaces;

namespace CustomerSvc.Infrastructure
{
    /// <summary>
    /// Class for executing CRUD operations
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerContext _context;

        public CustomerRepository(CustomerContext context)
        {
            _context = context;
        }

        public CustomerRepository()
        {
            _context = new CustomerContext();
        }

        #region CRUD

        /// <summary>
        /// Adds new customer's data
        /// </summary>
        /// <param name="customer"></param>
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.Entry(customer).State = System.Data.Entity.EntityState.Added;
            _context.SaveChanges();
        }

        /// <summary>
        /// Updates exisitng customer's data
        /// </summary>
        /// <param name="customer"></param>
        public void Update(Customer customer)
        {
            _context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
        }

        /// <summary>
        /// Deletes existing customer's data
        /// </summary>
        /// <param name="customerNumber"></param>
        public void Delete(int customerNumber)
        {
            Customer customer = _context.Customers.Find(customerNumber);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        /// <summary>
        /// Gets all customers' data
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        #endregion

        #region Find by specific parameter

        /// <summary>
        /// Finds the customer with a given id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        public Customer FindById(int id)
        {
            var customerResult = _context.Customers.FirstOrDefault(x => x.Id == id);
            return customerResult;
        }

        /// <summary>
        /// Finds the customer with a given customer's number
        /// </summary>
        /// <param name="customerNumber">Customer's number</param>
        /// <returns></returns>
        public Customer FindByCustomerNumber(string customerNumber)
        {
            var customerResult = _context.Customers.FirstOrDefault(x => x.CustomerNumber == customerNumber);
            return customerResult;
        }

        #endregion
    }
}
