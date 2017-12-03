using System;
using System.Collections.Generic;
using System.Text;
using CytarMultiPlayer;

namespace RobotBattleServer
{
    public class GameRoom: Room<GameRoom>
    {
        public GameRoom(string name, uint owner) : base(name, "A game room")
        {
            this.RoomInfo = new RoomInfo(name, owner);
        }

        public RoomInfo RoomInfo { get; set; }


    }
}
