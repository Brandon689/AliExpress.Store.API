using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class OriginalLayoutResultList
    {
        //[JsonPropertyName("contentLayout")]
        //public List<List<>> ContentLayout { get; set; }

        [JsonPropertyName("deliveryOptionPanelDisplayList")]
        public List<string> DeliveryOptionPanelDisplayList { get; set; }

        [JsonPropertyName("additionLayout")]
        public List<AdditionLayout> AdditionLayout { get; set; }

        [JsonPropertyName("titleLayout")]
        public List<object> TitleLayout { get; set; }

        [JsonPropertyName("finalPatternId")]
        public int? FinalPatternId { get; set; }

        [JsonPropertyName("bizData")]
        public BizData BizData { get; set; }

        [JsonPropertyName("dxTemplateInfo")]
        public DxTemplateInfo DxTemplateInfo { get; set; }

        [JsonPropertyName("detailFirstScreenDisplayList")]
        public List<string> DetailFirstScreenDisplayList { get; set; }

        [JsonPropertyName("skuSwitchDisplayList")]
        public List<string> SkuSwitchDisplayList { get; set; }
    }
}
