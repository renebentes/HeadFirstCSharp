using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Page366.GoFish
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Please enter your name", "Can't start the game yet");
                return;
            }

            game = new Game(textName.Text, new List<string> { "Joe", "Bob" }, textProgress);
            buttonStart.Enabled = false;
            textName.Enabled = false;
            buttonAsk.Enabled = true;

            updateForm();
        }

        private void updateForm()
        {
            listHand.Items.Clear();
            foreach (var cardName in game.GetPlayerCardName())
                listHand.Items.Add(cardName);

            textBook.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            textProgress.Text = "";
            if (listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }

            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                textProgress.Text += $"The winner is... {game.GetWinnerName()}";
                textBook.Text = game.DescribeBooks();
                buttonAsk.Enabled = false;
            }
            else
                updateForm();
        }
    }
}