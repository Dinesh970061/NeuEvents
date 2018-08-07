using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.DTOs
{
    public class CommentDto
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public string CommentText { get; set; }
        public DateTime? CommentTime { get; set; }
    }
}