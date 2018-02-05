using CustomerSvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    /// <summary>
    /// Host program which starts CustomerService
    /// </summary>
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var service = new ServiceHost(typeof(CustomerService), new Uri("http://localhost:51490/Services/CustomerService.svc"));
            service.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
            service.Description.Behaviors.Find<ServiceDebugBehavior>().IncludeExceptionDetailInFaults = true;
            service.AddServiceEndpoint(typeof(ICustomerService), new WSHttpBinding(), "");
            var customerServiceHost = new Host(service);

            if(!customerServiceHost.Start())
            {
                customerServiceHost.Stop();
                return;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            customerServiceHost.Stop();
        }
    }

    /// <summary>
    /// Class for setting the host
    /// </summary>
    internal class Host
    {
        private ServiceHost _svc;

        public Host(ServiceHost svc)
        {
            _svc = svc;
        }

        public bool Start()
        {
            var result = false;
            try
            {
                _svc.Open();
                Console.WriteLine("Service started");
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public void Stop()
        {
            try
            {
                if (_svc != null)
                {
                    _svc.Close();
                    _svc = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
