using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Page381
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine;

        public Form1()
        {
            InitializeComponent();

            breakfastLine = new Queue<Lumberjack>();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;

            if (crispy.Checked)
                food = Flapjack.Crispy;
            else if (soggy.Checked)
                food = Flapjack.Soggy;
            else if (browned.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            var currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);

            RedrawList();
        }

        private void RedrawList()
        {
            var number = 1;
            line.Items.Clear();

            foreach (var lumberjack in breakfastLine)
            {
                line.Items.Add($"{number}. {lumberjack.Name}");
                number++;
            }

            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                var currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = $"{currentLumberjack.Name} has {currentLumberjack.FlapjackCount} flapkacks";
            }
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            name.Text = "";

            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            var nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
            RedrawList();
        }
    }
}