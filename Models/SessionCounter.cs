using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{  
    public class SessionCounter
    {
        [JsonProperty]
        public int NumberOfGamesWon { get; private set; }
        [JsonProperty]
        public int NumberOfGamesAttempted { get; private set; }
        [JsonProperty]
        public int Score { get; private set; }

        public SessionCounter()
        {
            this.NumberOfGamesWon = 0;
            this.NumberOfGamesAttempted = 0;
            this.Score = 0;
        }

        public void IncrementNumberOfGamesWon()
        {
            this.NumberOfGamesWon++;
        }

        public void IncrementNumberOfGamesAttempted()
        {
            this.NumberOfGamesAttempted++;
        }

        public void ChangeScore(int roundScore)
        {
            this.Score += roundScore;
        }
    }
}
