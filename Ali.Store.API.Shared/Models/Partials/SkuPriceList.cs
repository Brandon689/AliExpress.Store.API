using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class SkuPriceList
    {
        [JsonPropertyName("skuVal")]
        public SkuVal SkuVal { get; set; }

        [JsonPropertyName("skuPropIds")]
        public string SkuPropIds { get; set; }

        [JsonPropertyName("skuIdStr")]
        public string SkuIdStr { get; set; }

        [JsonPropertyName("bannerInfo")]
        public BannerInfo BannerInfo { get; set; }

        [JsonPropertyName("freightExt")]
        public string FreightExt { get; set; }

        [JsonPropertyName("salable")]
        public bool? Salable { get; set; }

        [JsonPropertyName("skuAttr")]
        public string SkuAttr { get; set; }

        [JsonPropertyName("skuId")]
        public object SkuId { get; set; }
    }
}
