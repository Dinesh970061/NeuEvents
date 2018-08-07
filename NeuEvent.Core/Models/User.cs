using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<NotificationSubscriber> NotificationSubscriptions { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
