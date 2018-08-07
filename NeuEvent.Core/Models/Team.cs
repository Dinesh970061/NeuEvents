using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; }
        public virtual ICollection<Registration> Members { get; set; }
        public virtual ICollection<MatchFixtures> MatchFixturesTeam1 { get; set; }
        public virtual ICollection<MatchFixtures> MatchFixturesTeam2 { get; set; }

    }
}
