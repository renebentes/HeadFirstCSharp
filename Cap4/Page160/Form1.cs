using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page160
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Adicione uma tecla aleatória a Listbox
            listBox1.Items.Add((Keys) random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Se o usuário pressionou uma tecla que está em ListBox, remova-a
            // então, torne o jogo i pouco mais rápido
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 10;
                }
                if (timer1.Interval > 250)
                {
                    timer1.Interval -= 7;
                }
                if (timer1.Interval > 100)
                {
                    timer1.Interval -= 2;
                }
                difficultyProgressBar.Value = 800 - timer1.Interval;

                // O usuário pressionou uma tecla correta, portanto atualize o
                // objeto Stats chamando seu método Update() com argumento true
                stats.Update(true);
            }
            else
            {
                // O usuário pressionou uma tecla incorreta, portanto atualize o
                // objeto Stats chamando seu método Update() com argumento false
                stats.Update(false);
            }

            // Atualize as etiquetas em StatusStip
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}
