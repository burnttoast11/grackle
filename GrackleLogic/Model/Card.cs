using Grackle.Enums;

namespace Grackle.Models
{
    public class Card
    {
        public CardSuit Suit { get; set; }

        public CardValue Value { get; set; }

        public bool Played { get; set; }
    }
}