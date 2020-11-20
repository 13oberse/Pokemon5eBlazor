namespace BlazorUI.Contracts
{
    public sealed class PokedexExtraData
    {
#pragma warning disable 8618
        public string Flavor { get; set; }
#pragma warning restore 8618

        public int Height { get; set; }

        public int Weight { get; set; }

#pragma warning disable 8618
        public string Genus { get; set; }
#pragma warning restore 8618
    }
}
