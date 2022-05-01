using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class User : IdentityUser
    {
        public string FullName { get;set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public string Role { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
