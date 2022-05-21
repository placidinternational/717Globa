using _717Global.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _717Global.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact_us()
        {
            return View();
        }
        public IActionResult R_Canada()
        {
            return View();
        }
        public IActionResult R_Unitedstate()
        {
            return View();
        }
        public IActionResult R_Unitedkingdom()
        {
            return View();
        }
        public IActionResult R_Ireland()
        {
            return View();
        }
        public IActionResult R_Portugal()
        {
            return View();
        }
        public IActionResult R_Greece()
        {
            return View();
        }
        public IActionResult R_Spain()
        {
            return View();
        }
        public IActionResult R_Malta()
        {
            return View();
        }
        public IActionResult R_Australia()
        {
            return View();
        }
        public IActionResult C_kitts_nevis()
        {
            return View();
        }
        public IActionResult C_Dominica()
        {
            return View();
        }
        public IActionResult C_Grenada()
        {
            return View();
        }

        public IActionResult C_St_Lucia()
        {
            return View();
        }
        public IActionResult C_Antigua_Barbuda()
        {
            return View();
        }
        public IActionResult C_Turkey()
        {
            return View();
        }
        public IActionResult C_Montenegro()
        {
            return View();
        }
        public IActionResult Study_in_Austria()
        {
            return View();
        }
        public IActionResult Study_in_Sweden()
        {
            return View();
        }
        public IActionResult Study_in_Belgium()
        {
            return View();
        }
        public IActionResult Study_in_Canada()
        {
            return View();
        }
        public IActionResult Study_in_Portugal()
        {
            return View();
        }

        public IActionResult Study_in_UnitedKingdom()
        {
            return View();
        }
        public IActionResult Study_in_Unitedstates()
        {
            return View();
        }
        public IActionResult Internation_Realty()
        {
            return View();
        }
        public IActionResult Franchising()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}