using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class ChoiceAtmosphereComponent
    {
        [JsonPropertyName("serviceBlockIcon")]
        public ServiceBlockIcon ServiceBlockIcon { get; set; }

        [JsonPropertyName("logisticsBlockIcon")]
        public LogisticsBlockIcon LogisticsBlockIcon { get; set; }
    }
}
