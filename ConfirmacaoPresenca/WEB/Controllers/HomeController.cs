using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Negocio.Models;
using Negocio.Services.Base;
using WEB.ViewModels;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        private IConfirmacaoService _service;
        private IMapper _mapper;

        public HomeController(IConfirmacaoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

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
            if (ModelState.IsValid)
            {
                _service.Confirmar(_mapper.Map<RespostaConvidadoModel>(resposta));
                ViewData["title"] = "Obrigado";
                return View("Agradecimento", resposta);
            }
            else
            {
                return View("Formulario");
            }
        }
    }
}
