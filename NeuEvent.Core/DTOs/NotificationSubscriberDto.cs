using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.DTOs
{
    public class NotificationSubscriberDto
    {
        public int UserId { get; set; }
        public int NotificationId { get; set; }
        public DateTime? ViewedTime { get; set; }
        public Boolean HasViewed { get; set; }
    }
}
