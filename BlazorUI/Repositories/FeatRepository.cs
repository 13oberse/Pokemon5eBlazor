using BlazorUI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorUI.Repositories
{
    public static class FeatRepository
    {
        public static IEnumerable<KeyValuePair<string, FeatData>> GetFeats(string? name, string? description)
        {
            var dic = StaticData.Feats.AsEnumerable();
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
    }
}
