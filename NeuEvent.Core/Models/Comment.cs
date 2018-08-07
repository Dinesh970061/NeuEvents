using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.Models
{
     public class Comment
    {

        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }

        public virtual User User { get; set; }
        public virtual Event Event { get; set; }
    }
}
