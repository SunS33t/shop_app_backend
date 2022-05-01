using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Product
    {
        public Product()
        {
            ColorLists = new HashSet<ColorList>();
            Comments = new HashSet<Comment>();
            CustomerCarts = new HashSet<CustomerCart>();
            OrderLists = new HashSet<OrderList>();
            ProductLists = new HashSet<ProductList>();
        }

        public byte[] Picture { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public int? Weight { get; set; }
        public string Difficulty { get; set; }
        public string ProductId { get; set; }
        public string ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<ColorList> ColorLists { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CustomerCart> CustomerCarts { get; set; }
        public virtual ICollection<OrderList> OrderLists { get; set; }
        public virtual ICollection<ProductList> ProductLists { get; set; }
    }
}
