using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class MultilanguageUrlList
    {
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("languageUrl")]
        public string LanguageUrl { get; set; }
    }
}
