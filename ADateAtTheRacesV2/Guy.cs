using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADateAtTheRacesV2
{
    public class Guy
    {
        private string name;
        private int cash;

        public Guy(RadioButton radioButton, Label label, int startingCash)
        {
            Bet = new Bet(this);
            RadioLabel = radioButton;
            Label = label;
            name = radioButton.Text;
            cash = startingCash;
            UpdateLabels();
        }

        public RadioButton RadioLabel { get; private set; }

        public Label Label { get; private set; }

        public string Name => name;

        public Bet Bet { get; set; }

        public int Cash => cash;

        /// <summary>
        /// Sets label to my bets description and the label on my radio button to show my cash.
        /// </summary>
        public void UpdateLabels()
        {
            Label.Text = Bet.GetDescription();
            RadioLabel.Text = $"{Name} has {Cash} bucks.";
        }

        public void ClearBet()
        {
            Bet.ResetBet();
        }

        /// <summary>
        /// Place a new bet and store it in bet field
        /// </summary>
        /// <returns>return true if the guy had enough money to bet.</returns>
        public bool PlaceBet(int betAmount, int dogToWin)
        {
            Bet.Amount = betAmount;
            Bet.Dog = dogToWin;
            return betAmount <= Cash;
        }

        /// <summary>
        /// Ask my bet to pay out, clear my bet and update my labels.
        /// </summary>
        public void Collect(int winner)
        {
            cash += Bet.PayOut(winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
