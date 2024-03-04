using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class PackageComponent
    {
        [JsonPropertyName("inch_length")]
        public string InchLength { get; set; }

        [JsonPropertyName("lot")]
        public bool? Lot { get; set; }

        [JsonPropertyName("unitType")]
        public string UnitType { get; set; }

        [JsonPropertyName("length")]
        public int? Length { get; set; }

        [JsonPropertyName("lotNum")]
        public string LotNum { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("inch_height")]
        public string InchHeight { get; set; }

        [JsonPropertyName("weight")]
        public double? Weight { get; set; }

        [JsonPropertyName("pound_weight")]
        public string PoundWeight { get; set; }

        [JsonPropertyName("packageType")]
        public string PackageType { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("inch_width")]
        public string InchWidth { get; set; }
    }
}
