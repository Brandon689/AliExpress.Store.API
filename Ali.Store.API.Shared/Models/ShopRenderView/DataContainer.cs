using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class DataContainer
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("currentPage")]
        public int? CurrentPage { get; set; }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }

        [JsonPropertyName("filterConditionMap")]
        public FilterConditionMap FilterConditionMap { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        [JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        [JsonPropertyName("spQueryUrl")]
        public string SpQueryUrl { get; set; }

        [JsonPropertyName("summaryQueryUrl")]
        public string SummaryQueryUrl { get; set; }

        [JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        [JsonPropertyName("totalPage")]
        public int? TotalPage { get; set; }
    }
}
