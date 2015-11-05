using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Grackle.Enums
{
    public enum ConnectionStatus
    {
        [Description("Ready to play")]
        ReadyToPlay = 0,
        [Description("Challenging")]
        Challenging = 1,
        [Description("Challenged")]
        Challenged = 2,
        [Description("Playing")]
        Playing = 3
    }
}