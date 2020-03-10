using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class UserInfo
    {
        [Required]
        [Display(Name = "Choose a name")]
        public string UserName { get; set; }
        [Display(Name = "How many rounds would you like to play?")]
        public int NumberOfRounds { get; set; }
        [Display(Name = "Select your difficulty")]
        public string Difficulty { get; set; }

    }
}
