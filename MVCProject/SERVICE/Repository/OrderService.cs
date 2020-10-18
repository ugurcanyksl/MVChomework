using MODEL.Entities;
using SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Repository
{
    public class OrderService:BaseService<Order>
    {
        Order db = new Order();
        public string OrderRevenue()
        {
            return "Order Listesi";
        }
    }
}
