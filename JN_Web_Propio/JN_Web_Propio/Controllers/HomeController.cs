using JN_Web_Propio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JN_Web_Propio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Login( UsuarioModel model)
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
