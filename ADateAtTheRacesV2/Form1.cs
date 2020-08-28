using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADateAtTheRacesV2
{
    public partial class Form1 : Form
    {
        private const int minBetAmount = 5;
        private List<Greyhound> Greyhounds = new List<Greyhound>();
        private List<Guy> Guys = new List<Guy>();
        private readonly Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            Greyhounds.Add(new Greyhound(dog1, racetrackPictureBox.Width, random, 1));
            Greyhounds.Add(new Greyhound(dog2, racetrackPictureBox.Width, random, 2));
            Greyhounds.Add(new Greyhound(dog3, racetrackPictureBox.Width, random, 3));
            Greyhounds.Add(new Greyhound(dog4, racetrackPictureBox.Width, random, 4));

            Guys.Add(new Guy(joeRadioButton, joeBetLabel, 50));
            Guys.Add(new Guy(bobRadioButton, bobBetLabel, 75));
            Guys.Add(new Guy(alRadioButton, alBetLabel, 45));

            InitializeForm(minBetAmount);
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            foreach (Guy guy in Guys)
            {
                if (guy.RadioLabel.Checked)
                {
                    guy.PlaceBet((int)this.betAmount.Value, (int)this.dogNumber.Value);
                    guy.UpdateLabels();
                }
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void InitializeForm(int minBet)
        {
            foreach (Guy guy in Guys)
            {
                minimumBetLabel.Text = $"Minimum bet: {minBet} bucks.";
                guy.ClearBet();
                guy.UpdateLabels();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bettingParlorBox.Enabled = false;
            foreach (Greyhound greyhound in Greyhounds)
            {
                if (greyhound.Run())
                {
                    timer1.Stop();
                    foreach (Guy guy in Guys)
                    {
                        guy.Collect(guy.Bet.Dog);
                    }
                    MessageBox.Show($"Dog #{greyhound.Number} won the race!");
                    TakeStartingPosition();
                    bettingParlorBox.Enabled = true;
                }
            }
        }

        private void TakeStartingPosition()
        {
            foreach (Greyhound greyhound in Greyhounds)
            {
                greyhound.TakeStartingPosition();
            }
        }
    }
}
