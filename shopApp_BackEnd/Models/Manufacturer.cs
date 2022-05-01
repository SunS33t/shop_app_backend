using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }

        public string ManufacturerId { get; set; }
        public string BrandName { get; set; }
        public string Country { get; set; }
        public byte[] BrandLogo { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
