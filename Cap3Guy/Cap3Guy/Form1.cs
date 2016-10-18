using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap3Guy
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Name = "Joe", Cash = 50 };

            bob = new Guy() { Name = "Bob", Cash = 100 };

            UpdateForm();
        }

        public void UpdateForm()
        {
            lblJoeCash.Text = joe.Name + " tem R$" + joe.Cash;
            lblBobCash.Text = bob.Name + " tem R$" + bob.Cash;
            lblBankCash.Text = "O banco tem R$" + bank;
        }

        private void btnGiveJoe_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("O banco está sem dinheiro");
            }
        }

        private void btnReceiveBob_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void btnJoeGivesBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void btnBobGivesJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
