using CustomerSvc.Core;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CustomerSvc
{
    /// <summary>
    /// Service contract for ICustomerService
    /// </summary>
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ICustomerService
    {
        [OperationContract]
        void AddCustomer(Customer customer);

        [OperationContract]
        void UpdateCustomer(Customer customer);

        [OperationContract]
        void DeleteCustomer(int customerNumber);

        [OperationContract]
        IEnumerable<Customer> GetAll();

        [OperationContract]
        Customer FindByCustomerNumber(string customerNumber);

    }

}
