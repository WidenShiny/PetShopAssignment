using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {

        public void Create(Product product)
        {
            PetShopContext.Instance.Add(product);
            PetShopContext.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = GetProduct(id);
            PetShopContext.Instance.Remove(product);
            PetShopContext.Instance.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return PetShopContext.Instance.Products.ToList().FirstOrDefault(c => c.ProductId == id);
        }

        public List<Product> GetProducts() => PetShopContext.Instance.Products.ToList();

        public void Update()
        {
            PetShopContext.Instance.SaveChanges();
        }
    }
}
