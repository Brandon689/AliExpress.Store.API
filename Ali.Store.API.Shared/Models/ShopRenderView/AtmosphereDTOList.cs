using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class AtmosphereDTOList
    {
        [JsonPropertyName("isWarmup")]
        public bool? IsWarmup { get; set; }

        [JsonPropertyName("features")]
        public Features Features { get; set; }

        [JsonPropertyName("atmosphereCode")]
        public string AtmosphereCode { get; set; }

        [JsonPropertyName("materials")]
        public List<Material> Materials { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
    }
}
