using JN_Web_Propio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JN_Web_Propio.Controllers
{
    public class HomeController(HttpClient _httpClient, IConfiguration _configuration) : Controller
    {

        #region Inicio de sesión

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Login( LoginRequestModel model)
        {
            using var client = _httpClient;
            var url = _configuration.GetValue<string>("Variables:ApiBaseUrl") + "Home/Login";
            var response = client.PostAsJsonAsync(url, model).Result;

            return View();
        }
        #endregion

        #region Registro de Usuario

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Register(LoginRequestModel model)
        {
            using var client = _httpClient;
            var url = _configuration.GetValue<string>("Variables:ApiBaseUrl") + "Home /Register";
            var response = client.PostAsJsonAsync(url, model).Result;

            return View();
        }
        #endregion
        #region Recuperar Contraseña

        [HttpGet]
        public IActionResult Forgot()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Forgot(ForgotRequestModel model)
        {
            using var client = _httpClient;
            var url = _configuration.GetValue<string>("Variables:ApiBaseUrl") + "Home /Forgot";
            var response = client.PostAsJsonAsync(url, model).Result;

            return View();
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }
}
