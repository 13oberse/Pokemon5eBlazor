namespace BlazorUI.Contracts
{
    public sealed class PropertyRange<T>
    {
#pragma warning disable 8618
        public T Min { get; set; }

        public T Max { get; set; }
#pragma warning restore 8618
    }
}
