using System.Collections;
using System.Text.Json.Serialization;

namespace MyApps.TeamsClient.Models
{
    public class JsonFeed
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [JsonPropertyName("items")]
        public IEnumerable<JsonPost> Posts { get; set; }
    }
}
