using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class ReturnPromise
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("detailDescription")]
        public string DetailDescription { get; set; }

        [JsonPropertyName("oldPromiseId")]
        public string OldPromiseId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("type")]
        public int? Type { get; set; }

        [JsonPropertyName("descriptionForSeller")]
        public string DescriptionForSeller { get; set; }

        [JsonPropertyName("isValuable")]
        public bool? IsValuable { get; set; }

        [JsonPropertyName("descriptionPretty")]
        public string DescriptionPretty { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }
}
