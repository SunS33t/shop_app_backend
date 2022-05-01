using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class CustomerCart
    {
        public string ProductId { get; set; }
        public string UserId { get; set; }
        public int? Count { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer User { get; set; }
    }
}
