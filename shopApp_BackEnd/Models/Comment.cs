using System;
using System.Collections.Generic;

#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class Comment
    {
        public string ProductId { get; set; }
        public string UserId { get; set; }
        public string CommentId { get; set; }
        public DateTime? CommentDate { get; set; }
        public string CommentText { get; set; }
        public int? Mark { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer User { get; set; }
    }
}
