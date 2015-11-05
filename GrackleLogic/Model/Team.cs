using System.Collections.Generic;

namespace Grackle.Models
{
    public class Team
    {
        public Player TeamMember1 { get; set; }
        public Player TeamMember2 { get; set; }

        List<Trick> Tricks { get; set; }

        public Team (Player teamMember1, Player teamMember2)
        {
            TeamMember1 = teamMember1;
            TeamMember2 = teamMember2;

            Tricks = new List<Trick>();
        }
    }
}