using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class CrossLinkModule
    {
        [JsonPropertyName("BREADCRUMB_PART2")]
        public string BREADCRUMBPART2 { get; set; }

        [JsonPropertyName("BREADCRUMB_PART1")]
        public string BREADCRUMBPART1 { get; set; }

        [JsonPropertyName("CROSSLINK_RELATED_SEARCHES")]
        public string CROSSLINKRELATEDSEARCHES { get; set; }
    }
}
