using HardwareShop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HardwareShop.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class HSService : IHSService, IDisposable
    {
        readonly HSDbContext _ctx = new HSDbContext();
        //Na potrzeby WCF
        public void Dispose()
        {
            _ctx.Dispose();
        }
        public List<Customer> GetCustomer()
        {
            return _ctx.Customers.ToList();
        }
        public List<Product> GetProducts()
        {
            return _ctx.Products.ToList();
        }
        //transakcje przez WCF
        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            _ctx.Orders.Add(order);
            order.OrderItems.ForEach(o => _ctx.OrderItems.Add(o));
            _ctx.SaveChanges();
        }
    }
}
