using Grackle.Enums;
using Grackle.Models;
using System.Collections.Generic;

namespace Grackle.Models
{
    public class Game
    {
        public CardSuit Trump { get; set; }
        
        public Bidder Bidder { get; set; }

        public Player Player1 { get; set; }

        public Player Player2 { get; set; }

        public Player Player3 { get; set; }

        public Player Player4 { get; set; }

        public Team Team1 { get; set; }

        public Team Team2 { get; set; }

        public void StartNewGame(Player player1, Player player2, Player player3, Player player4)
        {
            Player1 = player1;
            Player2 = player2;
            Player3 = player3;
            Player4 = player4;

            Team1 = new Team(player1, player2);
            Team2 = new Team(player3, player4);
        }


    }
}