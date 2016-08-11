using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaMaze
{
    class Room
    {
        private int roomNum;
        private int appearanceID;
        public int door1;
        public int door2;
        public int door3;

        public Room(int roomNum, int appearanceID, int door1, int door2, int door3)
        {
            this.roomNum = roomNum;
            this.appearanceID = appearanceID;
            this.door1 = door1;
            this.door2 = door2;
            this.door3 = door3;
        }

        public int getRoomNum() { return roomNum; }
        public int getAppearanceID() { return appearanceID; }

    }
}
