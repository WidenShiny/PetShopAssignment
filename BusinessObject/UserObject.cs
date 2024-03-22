using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserObject
    {
		public int UserId { get; set; }

		public string UserName { get; set; }

		public string Email { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }

		public string Password { get; set; }

		public virtual ICollection<OrderObject> Orders { get; } = new List<OrderObject>();
    }
}
