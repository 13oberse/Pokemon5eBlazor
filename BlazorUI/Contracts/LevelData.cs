using System.Text.Json.Serialization;

namespace BlazorUI.Contracts
{
    public sealed class LevelData
    {
        [JsonPropertyName("prof")]
        public int Proficiency { get; set; }

        [JsonPropertyName("STAB")]
        public int SameTypeAttackBonus { get; set; }

        [JsonPropertyName("ASI")]
        public int AbilityScoreImprovements { get; set; }

        [JsonPropertyName("exp")]
        public int Experience { get; set; }
    }
}
