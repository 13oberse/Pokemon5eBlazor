namespace BlazorUI.Contracts
{
    public sealed class PokemonParameters
    {
        public string? Name { get; set; }

        public PokemonType? Type1 { get; set; }

        public PokemonType? Type2 { get; set; }

        public PropertyRange<int?> MinFieldLevel { get; set; } = new PropertyRange<int?>();

        public PropertyRange<int?> SRRange { get; set; } = new PropertyRange<int?>();

        public PropertyRange<int?> ACRange { get; set; } = new PropertyRange<int?>();
    }
}
