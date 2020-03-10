using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangman_Game.Extensions;
using Hangman_Game.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hangman_Game.Controllers
{
    public class GameController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public GameController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult UserInfo()
        {
            return View();
        }

        public IActionResult RegisterUser(UserInfo user)
        {
            if(!ModelState.IsValid)
            {
                return View("UserInfo");
            }
            HttpContext.Session.Set("user_info", user);
            HttpContext.Session.Set("number_games_played", 0);
            SessionCounter session = HttpContext.Session.Get<SessionCounter>("session_counter");

            if (session == null)
            {
                session = new SessionCounter();
            }

            HttpContext.Session.Set("session_counter", session);
            HangManGameBoard game = new HangManGameBoard();
            game.ReadyWord();
            HttpContext.Session.Set("current_game", game);

            ViewData["name"] = user.UserName;
            ViewData["score"] = session.Score;

            return View("CurrentGame", game);
            
        }
        [HttpPost]
        public IActionResult MakePlay(int index)
        {
            HangManGameBoard game = HttpContext.Session.Get<HangManGameBoard>("current_game");
            
            if (game == null)
            {
                game = new HangManGameBoard();
            }
            SessionCounter session = HttpContext.Session.Get<SessionCounter>("session_counter");

            if (session == null)
            {
                session = new SessionCounter();
            }

            bool isCorrectLetter = game.DoesContainLetter(index);
            if (isCorrectLetter)
            {
                ViewData["isCorrectLetter"] = isCorrectLetter;
            }

            game.CompleteRound(index);
            bool isGameOver = game.IsGameOver();
            if (isGameOver)
            {
                if (game.Counter.GuessesRemaining > 0)
                {
                    session.Score += game.TallyGameScore();
                    session.NumberOfGamesWon++;
                    session.NumberOfGamesAttempted++;
                    ViewData["score"] = session.Score;
                    HttpContext.Session.Set("session_counter", session);
                    return View("WinningMessage", game);
                }
                else
                {
                    return View("LosingMessage", game);
                }
            }
            HttpContext.Session.Set("current_game", game);




            UserInfo info = HttpContext.Session.Get<UserInfo>("user_info");
            ViewData["name"] = info == null ? "Unknown Player" : info.UserName;
            ViewData["score"] = session.Score;
            //HttpContext.Session.Set("session_counter", session);
            return View("CurrentGame", game);
        }

        public IActionResult ResetGame()
        {
            HttpContext.Session.Remove("current_game");
            return RedirectToAction("RegisterUser");
        }
    }
}