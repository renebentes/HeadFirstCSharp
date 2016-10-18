using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("nome é " + name + "\nx é " + x + "\nd é " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 10;
            if (x==10)
            {
                MessageBox.Show("x must be 10"); ;
            }
            else
            {
                MessageBox.Show("x isn't 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue==3) && (name=="Joe"))
            {
                MessageBox.Show("x is 3 and name is Joe");
            }
            MessageBox.Show("this line runs no matter what");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            MessageBox.Show("The answer is " + count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string result = "";
            int x = 3;
            while(x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }

                x = x - 1;
                result = result + "-";

                if (x == 2)
                {
                    result = result + "b c";
                }

                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }
            }
            MessageBox.Show(result);
        }
    }
}
