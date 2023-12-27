using System.Text.Json.Serialization;

namespace CSU.Contracts.V1.Requests
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NewsState
    {
        Active,
        Draft
    }
}
