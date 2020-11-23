using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorUI.Contracts
{
    public static class StaticData
    {
        public static string Select => "- Select -";

        public static JsonSerializerOptions Options => new JsonSerializerOptions
        {
            Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
            }
        };

#pragma warning disable 8618
        public static IReadOnlyDictionary<string, AbilityData> Abilities { get; set; }

        public static IReadOnlyDictionary<string, EvolveData> EvolveDictionary { get; set; }

        public static IReadOnlyDictionary<string, IReadOnlyDictionary<string, int>> ExpGrid { get; set; }

        public static IReadOnlyDictionary<string, FeatData> Feats { get; set; }

        public static IReadOnlyDictionary<string, FilterData> FilterData { get; set; }

        public static IReadOnlyDictionary<string, int> GenderDictionary { get; set; }

        public static IReadOnlyDictionary<string, List<string>> Habitat { get; set; }

        public static IReadOnlyDictionary<string, List<string>> IndexDictionary { get; set; }

        public static IReadOnlyDictionary<string, ItemData> Items { get; set; }

        public static IReadOnlyDictionary<string, LevelData> LevelDictionary { get; set; }

        // ReSharper disable once InconsistentNaming
        public static IReadOnlyDictionary<string, string> TMs { get; set; }

        public static IReadOnlyDictionary<string, IReadOnlyDictionary<string, int>> Natures { get; set; }

        public static IReadOnlyDictionary<string, PokedexExtraData> PokedexExtraDictionary { get; set; }

        public static IReadOnlyDictionary<string, List<string>> TrainerClasses { get; set; }

        public static IReadOnlyDictionary<string, List<string>> Variants { get; set; }

        public static IReadOnlyDictionary<string, MoveData> Moves { get; set; }

        public static IReadOnlyDictionary<string, PokemonData> PokemonDictionary { get; set; }
#pragma warning restore 8618
    }
}
