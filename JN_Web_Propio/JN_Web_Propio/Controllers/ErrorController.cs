using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace JN_Web_Propio.Controllers
{ 
    public class ErrorController : Controller
    {
        public IActionResult CapturarError()
        {
            var ex = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return View("Error");
        }
    }
}