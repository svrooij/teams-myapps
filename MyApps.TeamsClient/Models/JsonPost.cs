using Microsoft.AspNetCore.Components;
using System;
using System.Text.Json.Serialization;

namespace MyApps.TeamsClient.Models
{
    public class JsonPost
    {
        public string Title { get; set; }
        [JsonPropertyName("date_published")]
        public DateTimeOffset? DatePublished { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public IEnumerable<string>? Tags { get; set; }

        public string FullUrl => $"https://svrooij.io{Url}";

    }
}
