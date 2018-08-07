using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int EventId { get; set; }
        public string NotificationText { get; set; }
        public DateTime NotificationTime { get; set; }

        public virtual Event Event { get; set; }
        public virtual ICollection<NotificationSubscriber> Subscribers { get; set; }
    }
}
