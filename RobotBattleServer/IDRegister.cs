using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBattleServer
{
    public static class IDRegister
    {
        private static uint idGenerator = 0;

        public static uint NewID()
        {
            return idGenerator++;
        }


    }
}
