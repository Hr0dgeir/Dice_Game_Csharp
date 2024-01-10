using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    label6.Show();
                    label5.Show();
                    lap.Show();
                    win.Show();
                    hide();
                    player();
                    AI_dice();
                    winner();
                    break;
                case Keys.Q:
                    Environment.Exit(0);
                    break;
            }
        }
        int player_dice;
        public void player()
        {
            Random rnd1 = new Random();
            player_dice = rnd1.Next(1, 7);
            Thread.Sleep(10);
            switch (player_dice)
            {
                case 1:
                    Player_dice1.Show();
                    Player_dice1.Location = new Point(12, 134);
                    break;
                case 2:
                    Player_dice2.Show();
                    Player_dice2.Location = new Point(12, 134);
                    break;
                case 3:
                    Player_dice3.Show();
                    Player_dice3.Location = new Point(12, 134);
                    break;
                case 4:
                    Player_dice4.Show();
                    Player_dice4.Location = new Point(12, 134);
                    break;
                case 5:
                    Player_dice5.Show();
                    Player_dice5.Location = new Point(12, 134);
                    break;
                case 6:
                    Player_dice6.Show();
                    Player_dice6.Location = new Point(12, 134);
                    break;
            }
        }
        int ai_dice;
        public void AI_dice()
        {

            Random rnd = new Random();
            ai_dice = rnd.Next(1, 7);
            Thread.Sleep(10);
            switch (ai_dice)
            {
                case 1:
                    Ai_dice1.Show();
                    Ai_dice1.Location = new Point(274, 134);
                    break;
                case 2:
                    Ai_dice2.Show();
                    Ai_dice2.Location = new Point(274, 134);
                    break;
                case 3:
                    Ai_dice3.Show();
                    Ai_dice3.Location = new Point(274, 134);
                    break;
                case 4:
                    Ai_dice4.Show();
                    Ai_dice4.Location = new Point(274, 134);
                    break;
                case 5:
                    Ai_dice5.Show();
                    Ai_dice5.Location = new Point(274, 134);
                    break;
                case 6:
                    Ai_dice6.Show();
                    Ai_dice6.Location = new Point(274, 134);
                    break;

            }
        }
        int Win;
        int Lap;
        public void winner()
        {
            if (player_dice == ai_dice)
            {
                MessageBox.Show("Tie -- Press 'Enter' to play again");
                Lap++;
                lap.Text = "Lap :" + Lap;
            }
            if (player_dice < ai_dice)
            {
                MessageBox.Show("Ai Win -- Press 'Enter' to play again");
                Lap++;
                lap.Text = "Lap :" + Lap;
            }
            if (player_dice > ai_dice)
            {
                MessageBox.Show("Player Win -- Press 'Enter' to play again");
                Lap++;
                Win++;
                win.Text = "Win :" + Win;
                lap.Text = "Lap :" + Lap;
            }
        }

        public void hide()
        {
            Ai_dice1.Hide();
            Ai_dice2.Hide();
            Ai_dice3.Hide();
            Ai_dice4.Hide();
            Ai_dice5.Hide();
            Ai_dice6.Hide();
            Player_dice1.Hide();
            Player_dice2.Hide();
            Player_dice3.Hide();
            Player_dice4.Hide();
            Player_dice5.Hide();
            Player_dice6.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            win.Hide();
            lap.Hide();
            hide();
        }
    }
}
