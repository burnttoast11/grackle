using Grackle.Models;
using Grackle.Enums;
using Grackle.Enums.Helpers;

namespace Grackle.Models
{
    public class Player
    {
        public string ConnectionId { get; set; }

        public string Name { get; set; }

        public ConnectionStatus Status { get; set; }

        public string StatusLabel
        {
            get
            {
                return Status.GetDescription();
            }
        }
    }
}