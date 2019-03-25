using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalApp.Models;

namespace SignalApp.Controllers
{
    [Authorize]                                     //dodajemy sobie [Authorize] i to MVC nas przekierowywuje i każe się zalogować / zarejestrować
    public class HomeController : Controller
    {
        private UserManager<IdentityUser> _mgr;


        public HomeController(UserManager<IdentityUser> mgr)
        {
            _mgr = mgr;

        }

        public IActionResult Index()
        {
            string userId = _mgr.GetUserId(HttpContext.User);           //w ten sposób dostajemy się do zalogowanego usera do jego ID, wstrzyknęliśmy sobie do konstruktora Dependancy Injection klasą domyślnego usera (jest zdefiniowany w startup)
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
