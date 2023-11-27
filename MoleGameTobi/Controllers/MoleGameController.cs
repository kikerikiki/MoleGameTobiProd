using Microsoft.AspNetCore.Mvc;
using MoleGameTobi.Models;

namespace MoleGameTobi.Controllers
{
    public class MoleGameController : Controller
    {
        private MoleGame game;

        public MoleGameController()
        {
            game = new MoleGame();
        }

        public IActionResult Index()
        {
         

            return View();
        }

        public IActionResult StartGame()
        {
            game.Score = 0;
            game.StartTime = DateTime.Now;
            game.EndTime = game.StartTime.AddMinutes(1); // Adjust the game duration as needed
            game.IsGameOver = false;

            return RedirectToAction("Index");
        }

        public IActionResult EndOfGame()
        {
            if (!game.IsGameOver)
            {
                game.Score++;
            }

            return RedirectToAction("Index");
        }
        public IActionResult Game()
        {
           
            return View();
        }
    }
}
