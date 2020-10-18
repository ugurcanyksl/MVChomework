using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Order:EntityRepository
    {
        public Order()
        {
            Confirmed = false;
            OrderDetails = new List<OrderDetails>();
        }
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public bool Confirmed { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
