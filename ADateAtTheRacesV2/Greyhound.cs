using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADateAtTheRacesV2
{
    public class Greyhound
    {
        private int startingPosition;
        private int racetrackLength;
        private PictureBox PictureBox;
        private int location = 0;
        private Random random;
        private int number;

        public Greyhound(PictureBox pictureBox, int racetrackLength, Random random, int number)
        {
            this.PictureBox = pictureBox;
            this.startingPosition = pictureBox.Left;
            this.racetrackLength = racetrackLength - pictureBox.Width;
            this.random = random;
            this.number = number;
        }

        public int Number => number;

        /// <summary>
        /// Moves forward 1-4 spaces at random. Updates position of Picturebox.
        /// </summary>
        /// <returns>Returns true if dog won the race.</returns>
        public bool Run()
        {
            location += random.Next(1, 4);
            PictureBox.Left = startingPosition + location;
            return PictureBox.Left >= racetrackLength;
        }

        /// <summary>
        /// Reset location to 0 and my PictureBox to starting position.
        /// </summary>
        public void TakeStartingPosition()
        {
            location = 0;
            PictureBox.Left = startingPosition;
        }
    }
}
