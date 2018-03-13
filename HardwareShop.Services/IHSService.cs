using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HardwareShop.Services
{

    [ServiceContract]
    public interface IHSService
    {
        [OperationContract]
        List<Product> GetProducts();
        [OperationContract]
        List<Customer> GetCustomer();
        [OperationContract]
        void SubmitOrder(Order order);
    }

}
