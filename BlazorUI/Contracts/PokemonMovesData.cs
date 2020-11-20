using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorUI.Contracts
{
    public sealed class PokemonMovesData
    {
        [JsonPropertyName("Level")]
        public Dictionary<string, List<string>>? LearnByLevelUp { get; set; }

        [JsonPropertyName("Starting Moves")]
#pragma warning disable 8618
        public List<string> StartingMoves { get; set; }
#pragma warning restore 8618

        [JsonPropertyName("TM")]
        public List<int>? LearnByTM { get; set; }
    }
}
