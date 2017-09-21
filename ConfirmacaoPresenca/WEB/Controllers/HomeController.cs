using Microsoft.AspNetCore.Mvc;
using WEB.Models;

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

        [HttpPost]
        public IActionResult Confirmar(RespostaConvidadoViewModel resposta)
        {
            ViewData["title"] = "Obrigado";
            return View("Agradecimento", resposta);
        }
    }
}
