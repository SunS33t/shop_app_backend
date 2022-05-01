using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class ColorList
    {
        public string ColorCode { get; set; }
        public string ProductId { get; set; }

        public virtual Color ColorCodeNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
