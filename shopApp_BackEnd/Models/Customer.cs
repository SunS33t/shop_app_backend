using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Comments = new HashSet<Comment>();
            CustomerCarts = new HashSet<CustomerCart>();
            Orders = new HashSet<Order>();
        }

        public string UserId { get; set; }
        public string FullName { get; set; }
        public int Balance { get; set; }
        public string Email { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CustomerCart> CustomerCarts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
