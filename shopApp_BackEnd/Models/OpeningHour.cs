using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class OpeningHour
    {
        public string DayOfTheWeek { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public string ShopId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
