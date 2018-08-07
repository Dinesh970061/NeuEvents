using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.DTOs
{
    public class RegisterDto
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? TeamId { get; set; }
    }
}
