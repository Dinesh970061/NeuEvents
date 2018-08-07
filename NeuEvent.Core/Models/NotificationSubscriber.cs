using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.Models
{
    public class NotificationSubscriber
    {
        public int UserId { get; set; }
        public int NotificationId { get; set; }
        public DateTime? ViewedTime { get; set; }
        public Boolean HasViewed { get; set; }

        public virtual User User { get; set; }
        public virtual Notification Notification { get; set; }
    }
}
