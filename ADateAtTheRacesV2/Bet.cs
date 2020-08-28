using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADateAtTheRacesV2
{
    public class Bet
    {
        private readonly Guy bettor;

        private readonly Greyhound greyhoundBetOn;

        public Bet(Guy bettor)
        {
            this.bettor = bettor;
        }

        public int Amount { get; set; }

        public int Dog { get; set; }

        /// <summary>
        /// Return a string that says who places the bet, how much cash was bet,
        /// and which dog he bet on. If the amount is zero, no bet was placed.
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return Amount > 0 
                ? $"{bettor.Name} bets ${Amount} on dog #{Dog}." 
                : $"{bettor.Name} hasn't placed a bet.";
        }

        /// <summary>
        /// If the dog won, return the amount bet, otherwise return the negative of the bet amount.
        /// </summary>
        /// <param name="winner">The winner of the race</param>
        /// <returns>winnings or loses</returns>
        public int PayOut(int winner)
        {
            //if the dog is the winner, return the amount. Otherwise, return the negative amount.
            return Dog == winner ? Amount : -Amount;
        }

        public void ResetBet()
        {
            Amount = 0;
        }
    }
}
