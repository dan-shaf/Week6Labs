using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public static string username;
        public static string first;
        public static string last;
        public static string email;
        public static string password;
        public static string loginas = "Login";


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Lin(string user, string password)
        {
            if(user == HomeController.username && password == HomeController.password)
            {
                HomeController.loginas = user;
                return View();
            }
            else
            {
                return Content("Login Failed");
            }
        }
        public IActionResult LoginFailed()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Registered(string user, string first, string last, string email, string password)
        {
            HomeController.username = user;
            HomeController.first = first;
            HomeController.last = last;
            HomeController.email = email;
            HomeController.password = password;

            return View();
        }
        public IActionResult LinUpdate(string first, string last, string email, string password)
        {
            HomeController.first = first;
            HomeController.last = last;
            HomeController.email = email;
            HomeController.password = password;

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}