using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Shop
    {
        public Shop()
        {
            OpeningHours = new HashSet<OpeningHour>();
            ProductLists = new HashSet<ProductList>();
        }

        public string ShopName { get; set; }
        public string AdressId { get; set; }
        public string ShopId { get; set; }

        public virtual Adress Adress { get; set; }
        public virtual ICollection<OpeningHour> OpeningHours { get; set; }
        public virtual ICollection<ProductList> ProductLists { get; set; }
    }
}
