using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class FeedbackComponent
    {
        [JsonPropertyName("positiveRate")]
        public string PositiveRate { get; set; }

        [JsonPropertyName("fiveStarNum")]
        public int? FiveStarNum { get; set; }

        [JsonPropertyName("threeStarNum")]
        public int? ThreeStarNum { get; set; }

        [JsonPropertyName("twoStarRate")]
        public int? TwoStarRate { get; set; }

        [JsonPropertyName("display")]
        public bool? Display { get; set; }

        [JsonPropertyName("oneStarRate")]
        public int? OneStarRate { get; set; }

        [JsonPropertyName("fourStarNum")]
        public int? FourStarNum { get; set; }

        [JsonPropertyName("evarageStar")]
        public string EvarageStar { get; set; }

        [JsonPropertyName("fiveStarRate")]
        public int? FiveStarRate { get; set; }

        [JsonPropertyName("threeStarRate")]
        public int? ThreeStarRate { get; set; }

        [JsonPropertyName("totalValidNum")]
        public int? TotalValidNum { get; set; }

        [JsonPropertyName("evarageStarRage")]
        public string EvarageStarRage { get; set; }

        [JsonPropertyName("twoStarNum")]
        public int? TwoStarNum { get; set; }

        [JsonPropertyName("trialReviewNum")]
        public int? TrialReviewNum { get; set; }

        [JsonPropertyName("oneStarNum")]
        public int? OneStarNum { get; set; }

        [JsonPropertyName("fourStarRate")]
        public int? FourStarRate { get; set; }
    }
}
