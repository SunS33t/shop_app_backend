using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Admin
    {
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
