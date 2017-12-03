using System;
using System.Collections.Generic;
using System.Text;
using Cytar;

namespace RobotBattleServer
{
    public class RoomInfo: IDObject
    {
        public RoomInfo(string name, uint roomOwner)
        {
            Name = name;
            RoomOwner = roomOwner;
            ID = IDRegister.NewID();
            MaxPlayer = 32;
            PlayerCount = 0;
            Status = (byte)GameStatus.Waiting;
            MapID = 0;
        }

        [SerializableProperty(0)]
        public string Name { get; set; }
        [SerializableProperty(1)]
        public uint ID { get; set; }
        [SerializableProperty(2)]
        public int MaxPlayer { get; set; }
        [SerializableProperty(3)]
        public int PlayerCount { get; set; }
        [SerializableProperty(4)]
        public byte Status { get; set; }
        [SerializableProperty(5)]
        public uint MapID { get; set; }

        [SerializableProperty(6)]
        public uint RoomOwner { get; set; }

    }
}
