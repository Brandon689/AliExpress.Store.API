using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class ImageComponent
    {
        [JsonPropertyName("image250PathList")]
        public List<string> Image250PathList { get; set; }

        [JsonPropertyName("imagePathList")]
        public List<string> ImagePathList { get; set; }

        [JsonPropertyName("image640PathList")]
        public List<string> Image640PathList { get; set; }

        [JsonPropertyName("imageExist")]
        public bool? ImageExist { get; set; }

        [JsonPropertyName("imageServer")]
        public string ImageServer { get; set; }

        [JsonPropertyName("summImagePathList")]
        public List<string> SummImagePathList { get; set; }
    }
}
