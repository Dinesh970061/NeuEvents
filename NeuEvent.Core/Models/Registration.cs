using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.Models
{
    public class Registration
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int? TeamId { get; set; }

        public virtual User User { get; set; }
        public virtual Event Event { get; set; }
        public virtual Team Team { get; set; }
    }
}
