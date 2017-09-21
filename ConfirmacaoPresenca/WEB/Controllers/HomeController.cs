using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["title"] = "Início";
            return View("PaginaInicial");
        }

        [HttpGet]
        public IActionResult Formulario()
        {
            ViewData["title"] = "Confirmação de presença";
            return View();
        }
    }
}
