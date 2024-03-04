using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class ProductInfoComponent
    {
        [JsonPropertyName("idStr")]
        public string IdStr { get; set; }

        [JsonPropertyName("oddUnitName")]
        public string OddUnitName { get; set; }

        [JsonPropertyName("taobaoSellerName")]
        public string TaobaoSellerName { get; set; }

        [JsonPropertyName("src")]
        public string Src { get; set; }

        [JsonPropertyName("categoryPaths")]
        public string CategoryPaths { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("numberPerLot")]
        public int? NumberPerLot { get; set; }

        [JsonPropertyName("adminSeq")]
        public long? AdminSeq { get; set; }

        [JsonPropertyName("fromTaobao")]
        public bool? FromTaobao { get; set; }

        [JsonPropertyName("lot")]
        public bool? Lot { get; set; }

        [JsonPropertyName("multiCurrencyDisplayPrice")]
        public string MultiCurrencyDisplayPrice { get; set; }

        [JsonPropertyName("openOfferPriceRule")]
        public bool? OpenOfferPriceRule { get; set; }

        [JsonPropertyName("minPrice")]
        public double? MinPrice { get; set; }

        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("maxPrice")]
        public double? MaxPrice { get; set; }

        [JsonPropertyName("multiUnitName")]
        public string MultiUnitName { get; set; }

        [JsonPropertyName("categoryId")]
        public int? CategoryId { get; set; }
    }
}
