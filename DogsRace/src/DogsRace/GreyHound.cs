using System;
using System.Drawing;
using System.Windows.Forms;

namespace DogsRace
{
    public class GreyHound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            if (MyPictureBox.Location.X == RacetrackLength)
            {
                return true;
            }
            else
            {
                Point p = MyPictureBox.Location;
                p.X += Randomizer.Next(1, 4);
                MyPictureBox.Location = p;
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
