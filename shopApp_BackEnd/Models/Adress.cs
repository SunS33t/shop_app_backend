using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Adress
    {
        public Adress()
        {
            Orders = new HashSet<Order>();
            Shops = new HashSet<Shop>();
        }

        public string Street { get; set; }
        public string City { get; set; }
        public int HomeNumber { get; set; }
        public string AdditionalInformation { get; set; }
        public string AdressId { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
