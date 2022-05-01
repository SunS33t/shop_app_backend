using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderLists = new HashSet<OrderList>();
        }

        public string OrderId { get; set; }
        public string UserId { get; set; }
        public string AdressId { get; set; }
        public string Status { get; set; }

        public virtual Adress Adress { get; set; }
        public virtual Customer User { get; set; }
        public virtual ICollection<OrderList> OrderLists { get; set; }
    }
}
