using BlazorUI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorUI.Repositories
{
    public static class AbilityRepository
    {
        public static IEnumerable<KeyValuePair<string, AbilityData>> GetAbilities(string? name, string? description)
        {
            var dic = StaticData.Abilities.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(name))
            {
                dic = dic.Where(x => x.Key.Contains(name, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(description))
            {
                dic = dic.Where(x => x.Value.Description.Contains(description, StringComparison.CurrentCultureIgnoreCase));
            }

            return dic;
        }

        public static IEnumerable<KeyValuePair<string, PokemonData>> GetPokemonByAbility(string ability)
        {
            return StaticData.PokemonDictionary.Where(x => x.Value.Abilities.Contains(ability) || string.Equals(x.Value.HiddenAbility, ability));
        }
    }
}
