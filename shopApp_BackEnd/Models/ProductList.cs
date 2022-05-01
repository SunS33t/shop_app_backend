using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class ProductList
    {
        public string ShopId { get; set; }
        public string ProductId { get; set; }
        public int? Count { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
