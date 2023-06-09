using System.Text.Json.Serialization;

namespace MyApps.TeamsClient.Models
{
    public class ODataResult<TValue>
    {
        [JsonPropertyName("@odata.context")]
        public string Context { get; set; }
        public TValue Value { get; set; }
    }
}
