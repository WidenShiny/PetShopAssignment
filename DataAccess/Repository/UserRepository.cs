using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {

        public void Create(User user)
        {
            PetShopContext.Instance.Add(user);
            PetShopContext.Instance.SaveChanges();
        }

        public void Delete(string email)
        {
            User user = Getuser(email);
            PetShopContext.Instance.Remove(user);
            PetShopContext.Instance.SaveChanges();
        }

		public User Getuser(string email)
        {
            return PetShopContext.Instance.Users.ToList().FirstOrDefault(c => c.Email.Equals(email));
        }

        public List<User> Getusers() => PetShopContext.Instance.Users.ToList();

        public void Update()
        {
            PetShopContext.Instance.SaveChanges();
        }
    }
}
