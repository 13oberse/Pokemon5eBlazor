using BlazorUI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorUI.Repositories
{
    public static class ItemRepository
    {
        public static IEnumerable<KeyValuePair<string, ItemData>> GetItems(string? name, string? effect)
        {
            var query = StaticData.Items.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(x => x.Key.Contains(name, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(effect))
            {
                query = query.Where(x => x.Value.Effect.Contains(effect, StringComparison.CurrentCultureIgnoreCase));
            }

            return query;
        }
    }
}
