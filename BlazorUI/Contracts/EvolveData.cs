using System.Text.Json.Serialization;

namespace BlazorUI.Contracts
{
    public sealed class EvolveData
    {
#pragma warning disable 8618
        public string[] Into { get; set; }
#pragma warning restore 8618

        [JsonPropertyName("current_stage")]
        public int CurrentStage { get; set; }

        [JsonPropertyName("total_stages")]
        public int TotalStages { get; set; }

        public int Points { get; set; }

        public int Level { get; set; }
    }
}
