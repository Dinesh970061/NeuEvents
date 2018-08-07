using NeuEvent.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvent.Core.DTOs
{
    public class MatchFixturesDto
    {
        public int EventId { get; set; }
        public int MatchId { get; set; }
        public DateTime MatchDate { get; set; }
        public int? Team1Id { get; set; }
        public int? Team2Id { get; set; }
        public int? ParentFixtureId1 { get; set; }
        public int? ParentFixtureId2 { get; set; }
        public bool HasCompleted { get; set; }
        public string ResultDetails { get; set; }
        public int? WinnerId { get; set; }
    }
}
