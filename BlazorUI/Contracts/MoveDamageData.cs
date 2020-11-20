using System.Text.Json.Serialization;

namespace BlazorUI.Contracts
{
    public sealed class MoveDamageData
    {
        public int Amount { get; set; }

        [JsonPropertyName("dice_max")]
        public int DiceMax { get; set; }

        public bool Move { get; set; }
    }
}
