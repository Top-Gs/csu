using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSU.Contracts.V1.Responses
{
    public class MatchResponse
    {
        public required Guid Id { get; set; }
        public required DateTime Date { get; set; }
        public required string EnemyTeamName { get; set; }

        public string EnemyTeamLogo { get; set; }
        public required string Location { get; set; }
        public required string Arena { get; set; }
        public required string LiveLink { get; set; }

        public required string Score { get; set; }
        public required DateTime CreatedAt { get; set; }
        public Guid CreateBy { get; set; }
    }
}
