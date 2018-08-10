using NeuEvent.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NeuEvent.Core.Implementation.Services
{
    public class BaseService
    {
        private HttpClient _client;
        protected string BaseUrl = Constants.BaseUrl;

        public BaseService()
        {
            _client = new HttpClient();
        }

        public async Task<T> SendRequest<T>(HttpRequestMessage request)  where T : class
        {
            try
            {
                //TODO: Can set http headers here before send request

                //TODO: can set the http reuest settings and timeout settings

                var response = await _client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<T>(content);

                    return data;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }
    }
}
