using System.Text.Json.Serialization;

namespace BlazorUI.Contracts
{
    public sealed class FilterData
    {
        public int Index { get; set; }

#pragma warning disable 8618
        public PokemonType[] Type { get; set; }
#pragma warning restore 8618

        [JsonPropertyName("SR")]
        public double SpeciesRating { get; set; }

        [JsonPropertyName("MIN LVL FD")]
        public double MinimumFieldLevel { get; set; }
    }
}
