using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class Atmosphere
    {
        [JsonPropertyName("atmosphereDTOList")]
        public List<AtmosphereDTOList> AtmosphereDTOList { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("resourcePositionCode")]
        public string ResourcePositionCode { get; set; }
    }
}
