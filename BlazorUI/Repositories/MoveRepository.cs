using BlazorUI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorUI.Repositories
{
    public static class MoveRepository
    {
        public static IEnumerable<KeyValuePair<string, MoveData>> GetMoves(MoveParameters parameters)
        {
            var query = StaticData.Moves.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(parameters.Name))
            {
                query = query.Where(x => string.Equals(x.Key, parameters.Name, StringComparison.CurrentCultureIgnoreCase));
            }

            if (parameters.Type.HasValue)
            {
                query = query.Where(x => x.Value.Type == parameters.Type.Value);
            }

            if (!string.IsNullOrWhiteSpace(parameters.MovePower))
            {
                query = query.Where(x => x.Value.MovePower?.Contains(parameters.MovePower) == true);
            }

            if (parameters.MoveTime.HasValue)
            {
                query = query.Where(x => x.Value.MoveTimeEnum == parameters.MoveTime.Value);
            }

            if (parameters.PPRange.Min.HasValue)
            {
                query = query.Where(x => x.Value.PowerPoints >= parameters.PPRange.Min);
            }

            if (parameters.PPRange.Max.HasValue)
            {
                query = query.Where(x => x.Value.PowerPoints <= parameters.PPRange.Max);
            }

            if (parameters.Duration.HasValue)
            {
                query = query.Where(x => x.Value.DurationEnum == parameters.Duration.Value);
            }

            if (parameters.IsConcentration.HasValue)
            {
                query = query.Where(x => x.Value.IsConcentration == parameters.IsConcentration.Value);
            }

            if (parameters.IsAttackRoll.HasValue)
            {
                query = query.Where(x => x.Value.IsAttackRoll == parameters.IsAttackRoll.Value);
            }

            if (parameters.HasSave.HasValue)
            {
                query = query.Where(x => !string.IsNullOrWhiteSpace(x.Value.Save));
            }

            if (parameters.IsTM.HasValue)
            {
                query = query.Where(x => StaticData.TMs.ContainsKey(x.Key));
            }

            if (parameters.ScalesWithLevel.HasValue)
            {
                query = parameters.ScalesWithLevel.Value
                    ? query.Where(x => x.Value.Damage != null)
                    : query.Where(x => x.Value.Damage == null);
            }

            return query;
        }
    }
}
