using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {

        public void Create(Order order)
        {
            PetShopContext.Instance.Add(order);
            PetShopContext.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Order order = GetOrder(id);
            PetShopContext.Instance.Remove(order);
            PetShopContext.Instance.SaveChanges();
        }

        public Order GetOrder(int id)
        {
            return PetShopContext.Instance.Orders.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<Order> GetOrders() => PetShopContext.Instance.Orders.ToList();

        public void Update()
        {
            PetShopContext.Instance.SaveChanges();
        }
    }
}
