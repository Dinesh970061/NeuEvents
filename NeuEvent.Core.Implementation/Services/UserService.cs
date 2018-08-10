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
            var uri = $"{BaseUrl}/User/add";
            var httpRequest = new HttpRequestMessage()
            {
                RequestUri = new Uri(uri),
                Method = HttpMethod.Post
            };

            var result = await SendRequest<UserDto>(httpRequest);

            if (result != null)
            {
                return result.ConvertToModel();
            }
            return null;
        }

        public async Task<User> GetUserById(int userId)
        {
            var uri = $"{BaseUrl}/User/{userId}";
            var httpRequest = new HttpRequestMessage()
            {
                RequestUri = new Uri(uri),
                Method = HttpMethod.Get,
            };

            var result = await SendRequest<UserDto>(httpRequest);
            
            if(result != null)
            {
                return result.ConvertToModel();
            }
            return null;
        }
    }
}
