using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CytarMultiPlayer;
using Cytar;

namespace RobotBattleServer
{
    public class Hall : Room<GameRoom>
    {
        public List<GameRoom> GameRooms { get; set; }
        [CytarAPI("GetRooms")]
        public RoomInfo[] GetRooms()
        {
            return GameRooms.Select(room => room.RoomInfo).ToArray();
        }

        [CytarAPI("CreateRoom")]
        public RoomInfo CreateRoom(string roomName, uint mapID, CytarMPSession session)
        {
            var room = new GameRoom(roomName, session.ID);
            room.RoomInfo.MapID = mapID;
            this.AddSubRoom(room);
            return room.RoomInfo;
        }

        [CytarAPI("JoinRoom")]
        public void JoinRoom(uint RoomID)
        {

        }

        
    }
}
