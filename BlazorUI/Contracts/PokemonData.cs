using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorUI.Contracts
{
    public sealed class PokemonData
    {
#pragma warning disable 8618
        public PokemonMovesData Moves { get; set; }
#pragma warning restore 8618

        public int Index { get; set; }

#pragma warning disable 8618
        public List<string> Abilities { get; set; }
#pragma warning restore 8618

#pragma warning disable 8618
        public List<string> Type { get; set; }
#pragma warning restore 8618

        [JsonPropertyName("SR")]
        public double SpeciesRating { get; set; }

        [JsonPropertyName("AC")]
        public int ArmorClass { get; set; }

        [JsonPropertyName("Hit Dice")]
        public int HitDice { get; set; }

        public int HP { get; set; }

        [JsonPropertyName("WSp")]
        public int? WalkSpeed { get; set; }

        [JsonPropertyName("Ssp")]
        public int? SwimSpeed { get; set; }

        [JsonPropertyName("Fsp")]
        public int? FlySpeed { get; set; }

        [JsonPropertyName("Climbing Speed")]
        public int? ClimbSpeed { get; set; }

        public List<string>? Senses { get; set; }

#pragma warning disable 8618
        public Dictionary<string, int> Attributes { get; set; }
#pragma warning restore 8618

        [JsonPropertyName("MIN LVL FD")]
        public int MinimumFieldLevel { get; set; }

        public string? Evolve { get; set; }

        [JsonPropertyName("saving_throws")]
        public List<string>? SavingThrows { get; set; }

        [JsonPropertyName("Skill")]
        public List<string>? Skills { get; set; }

        [JsonPropertyName("Hidden Ability")]
        public string? HiddenAbility { get; set; }
    }
}
