using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class MultiLanguageUrlComponent
    {
        [JsonPropertyName("storeMultilanguageUrlList")]
        public List<StoreMultilanguageUrlList> StoreMultilanguageUrlList { get; set; }

        [JsonPropertyName("storeDetailUrl")]
        public string StoreDetailUrl { get; set; }

        [JsonPropertyName("multilanguageUrlList")]
        public List<MultilanguageUrlList> MultilanguageUrlList { get; set; }

        [JsonPropertyName("itemDetailUrl")]
        public string ItemDetailUrl { get; set; }

        [JsonPropertyName("mSiteUrl")]
        public string MSiteUrl { get; set; }
    }
}
