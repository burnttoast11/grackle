using GrackleLogic.Services;
using System.Collections.Generic;

namespace Grackle.Models
{
    public class Trick
    {
        public List<Card> Cards { get; set; }

        public int Points()
        {
            int total = 0;
            CardValueService cardValue = new CardValueService();
            foreach(var card in Cards)
            {
                total += cardValue.Value(card);
            }

            return total;
        }
    }
}