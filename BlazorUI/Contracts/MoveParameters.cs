namespace BlazorUI.Contracts
{
    public sealed class MoveParameters
    {
        public string? Name { get; set; }

        public PokemonType? Type { get; set; }

        public string? MovePower { get; set; }

        public MoveTime? MoveTime { get; set; }

        public PropertyRange<int?> PPRange { get; set; } = new PropertyRange<int?>();

        public MoveDuration? Duration { get; set; }

        public bool? IsConcentration { get; set; }

        public bool? IsAttackRoll { get; set; }

        public bool? HasSave { get; set; }

        public bool? IsTM { get; set; }

        public bool? ScalesWithLevel { get; set; }
    }
}
