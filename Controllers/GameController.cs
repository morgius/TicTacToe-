using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Helpers.AbstractFactory;
using TicTacToe.Helpers.Builder;
using System.Reflection;

namespace TicTacToe.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Small()
        {
            var director = new Director(BuilderFactory.GetBuilder(nameof(Small).ToLower()));
            director.Construct();
            return View(director.GetBoard);
        }
        public IActionResult Medium()
        {
            string method = MethodBase.GetCurrentMethod().Name;
            var director = new Director(BuilderFactory.GetBuilder(nameof(Small).ToLower()));
            director.Construct();
            return View(director.GetBoard);
        }
    }
}