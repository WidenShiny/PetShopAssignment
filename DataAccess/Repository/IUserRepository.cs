using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        List<User> Getusers();

        void Update();

        void Create(User member);

        void Delete(string email);

        User Getuser(string email);
    }
}
