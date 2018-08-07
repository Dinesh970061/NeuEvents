using NeuEvent.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User ConvertToModel()
        {
            var user = new User();
            user.UserId = UserId;
            user.UserName = UserName;
            user.FirstName = FirstName;
            user.LastName = LastName;

            return user;
        }
    }
}
