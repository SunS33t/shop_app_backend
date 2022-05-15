using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Color
    {
        public Color()
        {
            ColorLists = new HashSet<ColorList>();
        }

        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string ColorHex { get; set; }

        public virtual ICollection<ColorList> ColorLists { get; set; }
    }
}
