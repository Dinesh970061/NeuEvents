using NeuEvent.Core.Enums;
using NeuEvent.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.DTOs
{
    public class EventDto
    {
        public string EventName { get; set; }
        public int EventId { get; set; }
        public int OrganizerId { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RegistrationLockDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string EventImage { get; set; }
        public int? TeamCapacity { get; set; }
        public TimeSpan EventTime { get; set; }
        public string UserName { get; set; }
        public string RulesAndRegulations { get; set; }

        public Event ConvertToModel()
        {
            var events = new Event();
            events.EventId = EventId;
            events.EventName = EventName;
            events.OrganizerId = OrganizerId;
            events.Location = Location;
            events.Description = Description;
            events.StartDate = StartDate;
            events.EndDate = EndDate;
            events.RegistrationLockDate = RegistrationLockDate;
            events.CreationDate = CreationDate;
            events.EventImage = EventImage;
            events.EventTime = events.StartDate.TimeOfDay;
            events.RulesAndRegulations = RulesAndRegulations;

            return events;
        }
    }
}
