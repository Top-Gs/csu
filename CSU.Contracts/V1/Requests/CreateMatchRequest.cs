using Microsoft.AspNetCore.Http;

namespace CSU.Contracts.V1.Requests
{
    public class CreateMatchRequest
    {
       
        public required DateTime Date { get; set; }
        public required string EnemyTeamName { get; set; } = null!;       
        public IFormFile? EnemyTeamLogo { get; set; }
        public required string Location { get; set; } = null!;
        public required string Arena { get; set; } = null!;
        public required string LiveLink { get; set; } = null!;
        public required string Score { get; set; } = null!;

    }
}
