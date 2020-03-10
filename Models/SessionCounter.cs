using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class SessionCounter
    {
        public int NumberOfGamesWon { get; set; }

        public int NumberOfGamesAttempted { get; set; }

        public int Score { get; set; }

        public SessionCounter()
        {
            this.NumberOfGamesWon = 0;
            this.NumberOfGamesAttempted = 0;
            this.Score = 0;
        }
    }
}
