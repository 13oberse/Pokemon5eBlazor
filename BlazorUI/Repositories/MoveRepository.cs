using BlazorUI.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace BlazorUI.Repositories
{
    public static class MoveRepository
    {
        public static IEnumerable<KeyValuePair<string, MoveData>> GetMoves()
        {
            return StaticData.Moves.AsEnumerable();
        }
    }
}
