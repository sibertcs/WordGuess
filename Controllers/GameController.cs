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
        public IActionResult Main()
        {
            return View();
        }
        public IActionResult StartRound()
        {           
            SessionCounter session = HttpContext.Session.Get<SessionCounter>("session_counter");
            if (session == null)
            {
                session = new SessionCounter();
            }
            
            WordGuessGame game = HttpContext.Session.Get<WordGuessGame>("current_game");
            if (game == null)
            {
                game = new WordGuessGame();
            }

            game.ReadyWord();
            ViewData["score"] = session.Score;
            ViewData["roundNumber"] = session.NumberOfGamesAttempted + 1;

            HttpContext.Session.Set("session_counter", session);
            HttpContext.Session.Set("current_game", game);

            return View("CurrentGame", game); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MakePlay(int index)
        {
            WordGuessGame game = HttpContext.Session.Get<WordGuessGame>("current_game");
            SessionCounter session = HttpContext.Session.Get<SessionCounter>("session_counter");

            bool isGuessRight = game.DoesWordContainGuess(index);
            if (isGuessRight)
            {
                ViewData["isCorrectLetter"] = isGuessRight;
            }

            game.CompleteRound(index);
            bool isGameOver = game.IsGameOver();
            if (isGameOver)
            {
                session.ChangeScore(game.TallyRoundScore());
                session.IncrementNumberOfGamesAttempted();
                ViewData["score"] = session.Score;

                if (game.Counter.GuessesRemaining > 0)
                {                
                    session.IncrementNumberOfGamesWon();
                    HttpContext.Session.Set("session_counter", session);
                    return View("WinningMessage");
                }
                else
                {
                    HttpContext.Session.Set("session_counter", session);
                    return View("LosingMessage", game);
                }            
            }
            else
            {
                HttpContext.Session.Set("current_game", game);
                HttpContext.Session.Set("session_counter", session);
                ViewData["score"] = session.Score;
                ViewData["roundNumber"] = session.NumberOfGamesAttempted + 1;
                return View("CurrentGame", game);
            }           
        }

        public IActionResult EvaluateSession()
        {
            SessionCounter session = HttpContext.Session.Get<SessionCounter>("session_counter");
            if (session.NumberOfGamesAttempted == 10)
            {
                return View("SessionEnd", session);
            }
            else
            {
                return RedirectToAction("ResetGame");
            }
        }

        public IActionResult ResetGame()
        {
            HttpContext.Session.Remove("current_game");
            return RedirectToAction("StartRound");
        }

        public IActionResult ResetSession()
        {
            HttpContext.Session.Remove("current_game");
            HttpContext.Session.Remove("session_counter");
            return RedirectToAction("Main");
        }
    }
}