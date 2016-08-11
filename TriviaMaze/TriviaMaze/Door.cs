using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaMaze
{
    class Door
    {
        private bool locked;
        private int roomA;
        private int roomB;

        //roomA and roomB are the room numbers connected by that door.

        public Door(int roomA, int roomB)
        {
            locked = false;
            this.roomA = roomA;
            this.roomB = roomB;
        }

        public int getNextRoom(int r)
        {
            if(r == roomA) { return roomB; }
            else { return roomA; }
        }

        public bool getLocked() { return locked; }
        public void setLocked(bool isLocked) { locked = isLocked; }

        public int getRoomA() { return roomA; }
        public int getRoomB() { return roomB; }
    }
}
