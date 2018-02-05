using System.Collections.Generic;

namespace CustomerSvc.Core.Interfaces
{
    /// <summary>
    /// Repository for customers' data managing
    /// </summary>
    public interface ICustomerRepository
    {
        void Add(Customer entity);
        void Update(Customer entity);
        void Delete(int id);
        IEnumerable<Customer> GetAll();
        Customer FindById(int id);
        Customer FindByCustomerNumber(string customerNumber);
    }
}
