using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorUI.Contracts
{
    public sealed class MoveData
    {
        public PokemonType Type { get; set; }

        [JsonPropertyName("Move Power")]
        public List<string>? MovePower { get; set; }

        [JsonPropertyName("Move Time")]
#pragma warning disable 8618
        public string MoveTime { get; set; }
#pragma warning restore 8618

        [JsonPropertyName("PP")]
        public int PowerPoints { get; set; }

#pragma warning disable 8618
        public string Duration { get; set; }
#pragma warning restore 8618

#pragma warning disable 8618
        public string Range { get; set; }
#pragma warning restore 8618

        [JsonPropertyName("atk")]
        public bool IsAttackRoll { get; set; }

        public string? Save { get; set; }

#pragma warning disable 8618
        public string Description { get; set; }
#pragma warning restore 8618

        public Dictionary<string, MoveDamageData>? Damage { get; set; }
    }
}
