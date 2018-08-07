using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.DTOs
{
    public class NotificationDto
    {
        public int NotificationId { get; set; }
        public int EventId { get; set; }
        public string NotificationText { get; set; }
        public DateTime NotificationTime { get; set; }
    }
}
