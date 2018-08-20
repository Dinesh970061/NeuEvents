using NeuEvent.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.Models
{
     public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int OrganizerId { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RegistrationLockDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public EventTypeEnum EventType { get; set; }
        public FixtureTypeEnum? FixtureType { get; set; }
        public TeamTypeEnum? TeamType { get; set; }
        public string EventImage { get; set; }
        public int? TeamCapacity { get; set; }
        public string RulesAndRegulations { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<MatchFixtures> MatchFixtures { get; set; }
        public virtual User Organizer { get; set; }
        public TimeSpan EventTime { get; internal set; }
    }
}
