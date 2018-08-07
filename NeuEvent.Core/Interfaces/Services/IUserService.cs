using NeuEvent.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NeuEvent.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<User> GetUserById(int userId);

        Task<User> AddUser(User user);
    }
}
