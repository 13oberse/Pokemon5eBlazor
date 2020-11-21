using BlazorUI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorUI.Repositories
{
    public static class TypeRepository
    {
        public const float Immune = 0f;
        public const float DoubleResist = 0.25f;
        public const float Resist = 0.5f;
        public const float Normal = 1f;
        public const float Super = 2f;
        public const float DoubleSuper = 4f;

        public static List<PokemonType> GoodTypes { get; } = Enum.GetValues<PokemonType>().Where(x => x != PokemonType.Typeless && x != PokemonType.Varies).ToList();

        public static float Effectiveness(PokemonType attackingType, PokemonType defendingType)
        {
            switch (attackingType)
            {
                case PokemonType.Normal:
                    switch (defendingType)
                    {
                        case PokemonType.Ghost:
                            return Immune;
                        case PokemonType.Rock:
                        case PokemonType.Steel:
                            return Resist;
                        default:
                            return Normal;
                    }
                case PokemonType.Fire:
                    switch (defendingType)
                    {
                        case PokemonType.Fire:
                        case PokemonType.Water:
                        case PokemonType.Rock:
                        case PokemonType.Dragon:
                            return Resist;
                        case PokemonType.Grass:
                        case PokemonType.Ice:
                        case PokemonType.Bug:
                        case PokemonType.Steel:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Water:
                    switch (defendingType)
                    {
                        case PokemonType.Water:
                        case PokemonType.Grass:
                        case PokemonType.Dragon:
                            return Resist;
                        case PokemonType.Fire:
                        case PokemonType.Ground:
                        case PokemonType.Rock:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Electric:
                    switch (defendingType)
                    {
                        case PokemonType.Ground:
                            return Immune;
                        case PokemonType.Electric:
                        case PokemonType.Grass:
                        case PokemonType.Dragon:
                            return Resist;
                        case PokemonType.Water:
                        case PokemonType.Flying:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Grass:
                    switch (defendingType)
                    {
                        case PokemonType.Fire:
                        case PokemonType.Grass:
                        case PokemonType.Poison:
                        case PokemonType.Flying:
                        case PokemonType.Bug:
                        case PokemonType.Dragon:
                        case PokemonType.Steel:
                            return Resist;
                        case PokemonType.Water:
                        case PokemonType.Ground:
                        case PokemonType.Rock:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Ice:
                    switch (defendingType)
                    {
                        case PokemonType.Fire:
                        case PokemonType.Water:
                        case PokemonType.Ice:
                        case PokemonType.Steel:
                            return Resist;
                        case PokemonType.Grass:
                        case PokemonType.Ground:
                        case PokemonType.Flying:
                        case PokemonType.Dragon:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Fighting:
                    switch (defendingType)
                    {
                        case PokemonType.Ghost:
                            return Immune;
                        case PokemonType.Poison:
                        case PokemonType.Flying:
                        case PokemonType.Psychic:
                        case PokemonType.Bug:
                        case PokemonType.Fairy:
                            return Resist;
                        case PokemonType.Normal:
                        case PokemonType.Ice:
                        case PokemonType.Rock:
                        case PokemonType.Dark:
                        case PokemonType.Steel:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Poison:
                    switch (defendingType)
                    {
                        case PokemonType.Steel:
                            return Immune;
                        case PokemonType.Poison:
                        case PokemonType.Ground:
                        case PokemonType.Rock:
                        case PokemonType.Ghost:
                            return Resist;
                        case PokemonType.Grass:
                        case PokemonType.Fairy:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Ground:
                    switch (defendingType)
                    {
                        case PokemonType.Flying:
                            return Immune;
                        case PokemonType.Grass:
                        case PokemonType.Bug:
                            return Resist;
                        case PokemonType.Fire:
                        case PokemonType.Electric:
                        case PokemonType.Poison:
                        case PokemonType.Rock:
                        case PokemonType.Steel:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Flying:
                    switch (defendingType)
                    {
                        case PokemonType.Electric:
                        case PokemonType.Rock:
                        case PokemonType.Steel:
                            return Resist;
                        case PokemonType.Grass:
                        case PokemonType.Fighting:
                        case PokemonType.Bug:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Psychic:
                    switch (defendingType)
                    {
                        case PokemonType.Dark:
                            return Immune;
                        case PokemonType.Psychic:
                        case PokemonType.Steel:
                            return Resist;
                        case PokemonType.Fighting:
                        case PokemonType.Poison:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Bug:
                    switch (defendingType)
                    {
                        case PokemonType.Fire:
                        case PokemonType.Fighting:
                        case PokemonType.Poison:
                        case PokemonType.Flying:
                        case PokemonType.Ghost:
                        case PokemonType.Steel:
                        case PokemonType.Fairy:
                            return Resist;
                        case PokemonType.Grass:
                        case PokemonType.Psychic:
                        case PokemonType.Dark:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Rock:
                    switch (defendingType)
                    {
                        case PokemonType.Fighting:
                        case PokemonType.Ground:
                        case PokemonType.Steel:
                            return Resist;
                        case PokemonType.Fire:
                        case PokemonType.Ice:
                        case PokemonType.Flying:
                        case PokemonType.Bug:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Ghost:
                    switch (defendingType)
                    {
                        case PokemonType.Normal:
                            return Immune;
                        case PokemonType.Dark:
                            return Resist;
                        case PokemonType.Psychic:
                        case PokemonType.Ghost:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Dragon:
                    switch (defendingType)
                    {
                        case PokemonType.Fairy:
                            return Immune;
                        case PokemonType.Steel:
                            return Resist;
                        case PokemonType.Dragon:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Dark:
                    switch (defendingType)
                    {
                        case PokemonType.Fighting:
                        case PokemonType.Dark:
                        case PokemonType.Fairy:
                            return Resist;
                        case PokemonType.Psychic:
                        case PokemonType.Ghost:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Steel:
                    switch (defendingType)
                    {
                        case PokemonType.Fire:
                        case PokemonType.Water:
                        case PokemonType.Electric:
                        case PokemonType.Steel:
                            return Resist;
                        case PokemonType.Ice:
                        case PokemonType.Rock:
                        case PokemonType.Fairy:
                            return Super;
                        default:
                            return Normal;
                    }
                case PokemonType.Fairy:
                    switch (defendingType)
                    {
                        case PokemonType.Fire:
                        case PokemonType.Poison:
                        case PokemonType.Steel:
                            return Resist;
                        case PokemonType.Fighting:
                        case PokemonType.Dragon:
                        case PokemonType.Dark:
                            return Super;
                        default:
                            return Normal;
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(attackingType), attackingType, null);
            }
        }

        public static float Effectiveness(PokemonType attackingType, PokemonType defendingType1, PokemonType defendingType2)
        {
            return Effectiveness(attackingType, defendingType1) * Effectiveness(attackingType, defendingType2);
        }
    }
}
