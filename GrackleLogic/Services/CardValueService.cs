using Grackle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrackleLogic.Services
{
    public class CardValueService
    {
        public int Value(Card card)
        {
            switch(card.Value)
            {
                case Grackle.Enums.CardValue.Five:
                    return 5;
                case Grackle.Enums.CardValue.Ten:
                case Grackle.Enums.CardValue.Fourteen:
                    return 10;
                case Grackle.Enums.CardValue.One:
                    return 15;
                case Grackle.Enums.CardValue.Rookie:
                    return 20;
                default:
                    return 0;

            }
        }
    }
}
