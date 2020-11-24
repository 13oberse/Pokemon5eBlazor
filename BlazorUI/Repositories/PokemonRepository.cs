using BlazorUI.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace BlazorUI.Repositories
{
    public static class PokemonRepository
    {
        public static IEnumerable<KeyValuePair<string, PokemonData>> GetPokemon(PokemonParameters parameters)
        {
            var query = StaticData.PokemonDictionary.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(parameters.Name))
            {
                query = query.Where(x => string.Equals(x.Key, parameters.Name));
            }

            if (parameters.Type1.HasValue)
            {
                query = query.Where(x => x.Value.Type.Contains(parameters.Type1.Value.ToString()));
            }

            if (parameters.Type2.HasValue)
            {
                query = query.Where(x => x.Value.Type.Contains(parameters.Type2.Value.ToString()));
            }

            if (parameters.MinFieldLevel.Min.HasValue)
            {
                query = query.Where(x => x.Value.MinimumFieldLevel >= parameters.MinFieldLevel.Min.Value);
            }

            if (parameters.MinFieldLevel.Max.HasValue)
            {
                query = query.Where(x => x.Value.MinimumFieldLevel <= parameters.MinFieldLevel.Max.Value);
            }

            if (parameters.SRRange.Min.HasValue)
            {
                query = query.Where(x => x.Value.SpeciesRating >= parameters.SRRange.Min.Value);
            }

            if (parameters.SRRange.Max.HasValue)
            {
                query = query.Where(x => x.Value.SpeciesRating <= parameters.SRRange.Max.Value);
            }

            if (parameters.ACRange.Min.HasValue)
            {
                query = query.Where(x => x.Value.ArmorClass >= parameters.ACRange.Min.Value);
            }

            if (parameters.ACRange.Max.HasValue)
            {
                query = query.Where(x => x.Value.ArmorClass <= parameters.ACRange.Max.Value);
            }

            return query;
        }
    }
}
