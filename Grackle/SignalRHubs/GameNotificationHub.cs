using Grackle.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grackle.SignalRHubs
{
    public class GameNotificationHub : Hub
    {
        public override Task OnConnected()
        {
            // Reconnect player if already logged on
            if (!string.IsNullOrEmpty(Context.User.Identity.Name))
            {
                var player = GameManager.Instance.Players
                    .Where(x => x.Name == Context.User.Identity.Name)
                    .SingleOrDefault();

                if (player != null)
                {
                    player.ConnectionId = Context.ConnectionId;
                    Clients.Caller.updateSelf(player.Name);
                }
            }

            return base.OnConnected();
        }
    }
}
