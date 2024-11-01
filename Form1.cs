using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI___Card_Game
{

    public partial class Form1 : Form
    {
        Random generator = new Random();
        int card = 0; 
        int newCard;
        int money = 1000;
        int bet = 0;
        int guess = 0;
        int moneyEarned = 0;


        List<Bitmap> cards = new List<Bitmap> {
            Properties.Resources.card_back,
            Properties.Resources.ace_of_spades,
            Properties.Resources._2_of_spades,
            Properties.Resources._3_of_spades,
            Properties.Resources._4_of_spades,
            Properties.Resources._5_of_spades,
            Properties.Resources._6_of_spades,
            Properties.Resources._7_of_spades,
            Properties.Resources._8_of_spades,
            Properties.Resources._9_of_spades,
            Properties.Resources._10_of_spades,
            Properties.Resources.jack_of_spades2,
            Properties.Resources.queen_of_spades2,
            Properties.Resources.king_of_spades2
    };




        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd10_Click(object sender, EventArgs e)
        {
            if (money >= 10)
            {
                bet += 10;
                money -= 10;
                lblMoney.Text = "Money: $" + money;
                lblBet.Text = "Bet: $" + bet;
            }
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                bet += 100;
                money -= 100;
                lblMoney.Text = "Money: $" + money;
                lblBet.Text = "Bet: $" + bet;
            }
        }

        private void btnMinus10_Click(object sender, EventArgs e)
        {
            if (bet >= 10)
            {
                bet -= 10;
                money += 10;
                lblMoney.Text = "Money: $" + money;
                lblBet.Text = "Bet: $" + bet;
            }
        }

        private void btnMinus100_Click(object sender, EventArgs e)
        {
            if (bet >= 100)
            {
                bet -= 100;
                money += 100;
                lblMoney.Text = "Money: $" + money;
                lblBet.Text = "Bet: $" + bet;
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            bet += money;
            money = 0;
            lblMoney.Text = "Money: $" + money;
            lblBet.Text = "Bet: $" + bet;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            money += bet;
            bet = 0;
            lblMoney.Text = "Money: $" + money;
            lblBet.Text = "Bet: $" + bet;
        }

        private void btnHigher_Click(object sender, EventArgs e)
        {
            newCard = generator.Next(1, cards.Count);
            imgCard.Image = cards[newCard];
            if (newCard >= card)
            {
                moneyEarned += bet;
            }
            else
            {
                btnCashout.Visible = false;
                btnPlay.Visible = true;
                btnAdd10.Enabled = true;
                btnAdd100.Enabled = true;
                btnMinus10.Enabled = true;
                btnMinus100.Enabled = true;
                btnMax.Enabled = true;
                btnClear.Enabled = true;
                btnLower.Enabled = false;
                btnHigher.Enabled = false;
                btnHigher.BackColor = Color.Gray;
                btnLower.BackColor = Color.Gray;
                moneyEarned = 0;
                bet = 0;

            }
            lblEarned.Text = "This Round: $" + moneyEarned;
            lblBet.Text = "Bet: $" + bet;
            card = newCard;

            
        }
        private void btnLower_Click(object sender, EventArgs e)
        {
            newCard = generator.Next(1, cards.Count);
            imgCard.Image = cards[newCard];
            if (newCard <= card)
            {
                moneyEarned += bet;
            }
            else
            {
                btnCashout.Visible = false;
                btnPlay.Visible = true;
                btnAdd10.Enabled = true;
                btnAdd100.Enabled = true;
                btnMinus10.Enabled = true;
                btnMinus100.Enabled = true;
                btnMax.Enabled = true;
                btnClear.Enabled = true;
                btnLower.Enabled = false;
                btnHigher.Enabled = false;
                btnHigher.BackColor = Color.Gray;
                btnLower.BackColor = Color.Gray;
                moneyEarned = 0;
                bet = 0;

            }
            lblEarned.Text = "This Round: $" + moneyEarned;
            lblBet.Text = "Bet: $" + bet;
            card = newCard;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnCashout.Visible = true;
            btnAdd10.Enabled = false;
            btnAdd100.Enabled = false;
            btnMinus10.Enabled = false;
            btnMinus100.Enabled = false;
            btnMax.Enabled = false;
            btnClear.Enabled = false;
            btnHigher.Enabled = true;
            btnLower.Enabled = true;
            btnHigher.BackColor = Color.Lime;
            btnLower.BackColor = Color.Red;
            card = generator.Next(1, cards.Count);
            imgCard.Image = cards[card];
            moneyEarned += bet;
        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            btnCashout.Visible = false;
            btnPlay.Visible = true;
            btnAdd10.Enabled = true;
            btnAdd100.Enabled = true;
            btnMinus10.Enabled = true;
            btnMinus100.Enabled = true;
            btnMax.Enabled = true;
            btnClear.Enabled = true;
            btnLower.Enabled = false;
            btnHigher.Enabled = false;
            btnHigher.BackColor = Color.Gray;
            btnLower.BackColor = Color.Gray;
            money += moneyEarned;
            moneyEarned = 0;
            bet = 0;
            lblMoney.Text = "Money: $" + money;
            lblEarned.Text = "This Round: $" + moneyEarned;
            lblBet.Text = "Bet: $" + bet;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
