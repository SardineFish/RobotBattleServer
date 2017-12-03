using System;
using System.Collections.Generic;
using System.Text;
using CytarMultiPlayer;
using Cytar;

namespace RobotBattleServer
{
    public class GamePlay: APIContext
    {
        [CytarAPI("bcctrl")]
        public void BroadcastControl(CytarMPSession session)
        {

        }
    }
}
