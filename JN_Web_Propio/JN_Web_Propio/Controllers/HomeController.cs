
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JN_Web_Propio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
