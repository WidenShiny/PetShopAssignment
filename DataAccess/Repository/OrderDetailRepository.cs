using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {

        public void Create(OrderDetail orderDetail)
        {
            PetShopContext.Instance.Add(orderDetail);
            PetShopContext.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            OrderDetail orderDetail = GetOrderDetail(id);
            PetShopContext.Instance.Remove(orderDetail);
            PetShopContext.Instance.SaveChanges();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return PetShopContext.Instance.OrderDetails.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<OrderDetail> GetOrderDetails() => PetShopContext.Instance.OrderDetails.ToList();

        public void Update()
        {
            PetShopContext.Instance.SaveChanges();
        }
    }
}
