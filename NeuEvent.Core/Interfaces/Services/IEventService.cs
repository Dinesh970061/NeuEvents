using NeuEvent.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NeuEvent.Core.Interfaces.Services
{
   public interface IEventService
    {
        Task<Event> GetEventById(int eventId);

        Task<Event> AddEvent(Event events);
    }
}
