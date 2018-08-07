using NeuEvent.Core.Interfaces.Services;
using NeuEvent.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using NeuEvent.Core.DTOs;

namespace NeuEvent.Core.Implementation.Services
{
    public class UserService : BaseService, IUserService
    {
        public async Task<User> AddUser(User user)
        {
            var httpRequest = new HttpRequestMessage();

            var result = await SendRequest<UserDto>(httpRequest);

            if (result != null)
            {
                return result.ConvertToModel();
            }
            return null;
        }

        public async Task<User> GetUserById(int userId)
        {
            var httpRequest = new HttpRequestMessage();
            
            var result = await SendRequest<UserDto>(httpRequest);
            
            if(result != null)
            {
                return result.ConvertToModel();
            }
            return null;
        }
    }
}
