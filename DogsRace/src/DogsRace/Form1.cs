using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogsRace
{
    public partial class Form1 : Form
    {
        Guy[] guy;
        GreyHound[] dog;
        Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMinimum.Text = "Minimum bet: " + numericUpDown1.Minimum.ToString() + " bucks";
            random = new Random();

            guy = new Guy[3];
            guy[0] = new Guy() { Name = "Joe", Cash = 50, MyLabel = label3, MyRadioButton = radioButton1, MyBet = null };
            guy[1] = new Guy() { Name = "Bob", Cash = 75, MyLabel = label4, MyRadioButton = radioButton2, MyBet = null };
            guy[2] = new Guy() { Name = "Al", Cash = 45, MyLabel = label5, MyRadioButton = radioButton3, MyBet = null };

            dog = new GreyHound[4];
            dog[0] = new GreyHound() { StartingPosition = pictureBox2.Location.X, MyPictureBox = pictureBox2, RacetrackLength = pictureBox1.Size.Width, Randomizer = random };
            dog[1] = new GreyHound() { StartingPosition = pictureBox3.Location.X, MyPictureBox = pictureBox3, RacetrackLength = pictureBox1.Size.Width, Randomizer = random };
            dog[2] = new GreyHound() { StartingPosition = pictureBox4.Location.X, MyPictureBox = pictureBox4, RacetrackLength = pictureBox1.Size.Width, Randomizer = random };
            dog[3] = new GreyHound() { StartingPosition = pictureBox5.Location.X, MyPictureBox = pictureBox5, RacetrackLength = pictureBox1.Size.Width, Randomizer = random };

            foreach (var g in guy)
            {
                g.UpdateLabels();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var g in guy)
            {
                if (g.Name == label6.Text)
                {
                    if (g.PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                    {
                        g.UpdateLabels();
                    }                    
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = guy[0].Name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = guy[1].Name;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = guy[2].Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            bool winner = false;
            button1.Enabled = false;
            button2.Enabled = false;

            while (winner == false)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (dog[i].Run())
                    {
                        MessageBox.Show("We have a winner - dog #" + i);

                        foreach (var g in guy)
                        {
                            g.Collect(i);
                            g.ClearBet();
                            g.UpdateLabels();
                        }
                        winner = true;
                    }
                }
            }            

            button1.Enabled = true;
            button2.Enabled = true;

            foreach (var d in dog)
            {
                d.TakeStartingPosition();
            }
        }
    }
}
