using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaMaze
{
    public partial class Form1 : Form
    {
        Room[] rooms;
        Door[] doors;
        int startRoom = 1;
        int endRoom = 4;
        int curRoom;

        public TriviaManager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new TriviaManager();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"Assets\Calm.wav");
            sp.PlayLooping();
            //sp.Play();
            panel1.BackColor = Color.FromArgb(100,88, 44, 55);
            door1.Parent = wall;
            door2.Parent = wall;
            door3.Parent = wall;
            door1.Controls.Add(log1);
            log1.Location = new Point(0, 75);
            log1.BackColor = Color.Transparent;
            door2.Controls.Add(log2);
            log2.Location = new Point(50, 50);
            log2.BackColor = Color.Transparent;
            door3.Controls.Add(log3);
            log3.Location = new Point(75, 75);
            log3.BackColor = Color.Transparent;
            setup();
        }

        private void setup()
        {
            curRoom = startRoom;
            doors = new Door[21];

            doors[0] = new Door(1, 1);
            doors[1] = new Door(1, 5);
            doors[2] = new Door(1, 2);
            doors[3] = new Door(2, 6);
            doors[4] = new Door(2, 3);
            doors[5] = new Door(3, 7);
            doors[6] = new Door(3, 4);
            doors[7] = new Door(4, 8);
            doors[8] = new Door(5, 9);
            doors[9] = new Door(5, 6);
            doors[10] = new Door(6, 10);
            doors[11] = new Door(7, 8);
            doors[12] = new Door(8, 12);
            doors[13] = new Door(9, 13);
            doors[14] = new Door(10, 14);
            doors[15] = new Door(11, 15);
            doors[16] = new Door(11, 12);
            doors[17] = new Door(12, 16);
            doors[18] = new Door(13, 14);
            doors[19] = new Door(14, 15);
            doors[20] = new Door(15, 16);


            //empty room in room[0]. Makes 1 based indexing.
            rooms = new Room[17];

            //DOOR 0 IS A BLANK DOOR (ie a door not to display)
            rooms[1] = new Room(1, 1, 2, 1, 0);
            rooms[2] = new Room(2, 2, 2, 3, 4);
            rooms[3] = new Room(3, 3, 4, 5, 6);
            rooms[4] = new Room(4, 2, 6, 0, 7);
            rooms[5] = new Room(5, 2, 1, 9, 8);
            rooms[6] = new Room(6, 1, 3, 9, 10);
            rooms[7] = new Room(7, 3, 5, 11, 0);
            rooms[8] = new Room(8, 2, 7, 11, 12);
            rooms[9] = new Room(9, 1, 8, 0, 13);
            rooms[10] = new Room(10, 2, 10, 0, 14);
            rooms[11] = new Room(11, 2, 0, 15, 16);
            rooms[12] = new Room(12, 3, 12, 16, 17);
            rooms[13] = new Room(13, 1, 13, 18, 0);
            rooms[14] = new Room(14, 2, 18, 14, 19);
            rooms[15] = new Room(15, 3, 19, 15, 20);
            rooms[16] = new Room(2, 2, 20, 17, 0);

            loadRoom(curRoom);

        }

        private void loadRoom(int roomNum)
        {
            Room cur = rooms[roomNum];
            curRoom = roomNum;

            if(roomNum == endRoom)
            {
                GameOver(true);
                //MessageBox.Show("YOU MADE IT OUT!");
                //MessageBox.Show("should do some type of replay prompt here");
            }

            //room_num_label.Text = "room " + roomNum;

            //changeAppearance(cur.getAppearanceID());
            setDoors(cur.door1, cur.door2, cur.door3);
        }

        private void setDoors(int d1, int d2, int d3)
        {
            door1.Visible = true;
            log1.Visible = doors[d1].getLocked();
            //if (button1.Enabled) { button1.Text = "Open"; }
            //else { button1.Text = "Locked"; }
            //d1_label.Text = "door " + d1;

            door2.Visible = true;
            log2.Visible = doors[d2].getLocked();
          //  if (button2.Enabled) { button2.Text = "Open"; }
           // else { button2.Text = "Locked"; }
           // d2_label.Text = "door " + d2;

            door3.Visible = true;
            log3.Enabled = doors[d3].getLocked();
            //if (button3.Enabled) { button3.Text = "Open"; }
            //else { button3.Text = "Locked"; }
            //d3_label.Text = "door " + d3;

            if(d1 == 0) { door1.Visible = false; log1.Visible = false; }
            if (d2 == 0) { door2.Visible = false; log2.Visible = false; }
            if (d3 == 0) { door3.Visible = false; log3.Visible = false; }
        }

     /*   private void changeAppearance(int aNum)
        {
            if (aNum == 1)
            {
                wall.BackColor = Color.LightSeaGreen;
                trim.BackColor = Color.White;
                floor.BackColor = Color.Gray;
            }
            else if(aNum == 2)
            {
                wall.BackColor = Color.DeepSkyBlue;
                trim.BackColor = Color.White;
                floor.BackColor = Color.Beige;
            }
            else
            {
                wall.BackColor = Color.HotPink;
                trim.BackColor = Color.White;
                floor.BackColor = Color.Gray;
            }
        }*/

        private void gameOver()
        {
            //MessageBox.Show("You died in the woods. Sorry not sorry");
            GameOver(false);
        }

        private void GameOver(bool didIWin)
        {
            panel1.Show();
            WinOrLose.Text = didIWin ? "You Made It Out Alive!" : "You Died in the Woods!";
        }

        private bool allDoorsLocked()
        {
           if(log1.Visible|| log2.Visible|| log3.Visible)
            {
                return false;
            }

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private bool displayQuestion()
        {
            TriviaManager.TriviaQuestion q = new TriviaManager.TriviaQuestion();
            q = manager.GetRandomTriviaQuestion();
            bool answer;
            using (Form2 f2 = new Form2(q.Question, q.AnswerA, q.AnswerB, q.AnswerC, q.AnswerD, q.Answer))
            {
                f2.ShowDialog();
                answer = f2.correct;
            }
            return answer;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setup();
            panel1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void door2_Click(object sender, EventArgs e)
        {
            bool correct = displayQuestion();


            if (correct)
            {
                MessageBox.Show("Correct!");
                int curDoor = rooms[curRoom].door2;
                int nextRoom = doors[curDoor].getNextRoom(curRoom);

                loadRoom(nextRoom);
            }

            else
            {
                log2.Visible = true;
                //button2.Text = "Locked!";

                doors[rooms[curRoom].door2].setLocked(true);
                if (allDoorsLocked()) { gameOver(); }
            }
        }

        private void door1_Click(object sender, EventArgs e)
        {
            bool correct = displayQuestion();

            if (correct)
            {
                MessageBox.Show("Correct!");
                int curDoor = rooms[curRoom].door1;
                int nextRoom = doors[curDoor].getNextRoom(curRoom);

                loadRoom(nextRoom);

            }

            else
            {

                log1.Visible = true;
                //button1.Text = "Locked!";
                doors[rooms[curRoom].door1].setLocked(true);
                if (allDoorsLocked()) { gameOver(); }
            }
        }

        private void door3_Click(object sender, EventArgs e)
        {
            bool correct = displayQuestion();

            if (correct)
            {
                MessageBox.Show("Correct!");
                int curDoor = rooms[curRoom].door3;
                int nextRoom = doors[curDoor].getNextRoom(curRoom);

                loadRoom(nextRoom);
            }

            else
            {
                log3.Visible = true;
                //button3.Text = "Locked!";
                doors[rooms[curRoom].door3].setLocked(true);
                if (allDoorsLocked()) { gameOver(); }
            }
        }
    }
}
