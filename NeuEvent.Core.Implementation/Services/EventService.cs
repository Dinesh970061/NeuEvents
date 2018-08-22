using NeuEvent.Core.DTOs;
using NeuEvent.Core.Interfaces.Services;
using NeuEvent.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeuEvent.Core.Implementation.Services
{
    public class EventService : BaseService, IEventService
    {
        public async Task<Event> AddEvent(Event events)
        {
            var uri = $"{BaseUrl}/events/add";
            var httpRequest = new HttpRequestMessage()
            {
                RequestUri = new Uri(uri),
                Method = HttpMethod.Post,
            };
            var result = await SendRequest<EventDto>(httpRequest);

            if (result != null)
            {
                return result.ConvertToModel();
            }
            return null;
        }

        public async Task<Event> GetEventById(int eventId)
        {
            var uri = $"{BaseUrl}/events/{eventId}";
            var httpRequest = new HttpRequestMessage()
            {
                RequestUri = new Uri(uri),
                Method = HttpMethod.Get,
            };

            var result = await SendRequest<EventDto>(httpRequest);

            if (result != null)
            {
                return result.ConvertToModel();
            }
            return null;
        }
    }
}
