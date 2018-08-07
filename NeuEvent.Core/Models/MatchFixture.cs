using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.Models
{
    public class MatchFixtures
    {
        public int MatchId { get; set; }
        public int EventId { get; set; }
        public DateTime MatchDate { get; set; }
        public int? Team1Id { get; set; }
        public int? Team2Id { get; set; }
        public bool HasCompleted { get; set; }
        public int? ParentFixtureId1 { get; set; }
        public int? ParentFixtureId2 { get; set; }

        public string ResultDetails { get; set; }
        public int? WinnerId { get; set; }

        public virtual Event Event { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Team Team2 { get; set; }
        public virtual Team Winner { get; set; }
    }
}
