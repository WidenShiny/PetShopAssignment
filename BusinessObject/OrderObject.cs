using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderObject
    {
		public int OrderId { get; set; }

		public int UserId { get; set; }

		public DateTime OrderDate { get; set; }

		public DateTime? RequiredDate { get; set; }

		public DateTime? ShippedDate { get; set; }

		public decimal? TotalMoney { get; set; }

		public virtual UserObject Member { get; set; }

        public virtual OrderDetailObject OrderDetail { get; set; }
    }
}
