using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSU.Contracts.V1.Requests;
namespace CSU.Contracts.V1.Responses
{
    public class SponsorsResponse
    {
        public required Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreateBy { get; set; }

        public string Image { get; set; }
    }
}
