using DataAcess.Data;
using Microsoft.AspNetCore.Mvc;
using ProcessoFIAP.Models;
using System.Diagnostics;

namespace ProcessoFIAP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlunoData _aluno;
        public HomeController(ILogger<HomeController> logger, IAlunoData aluno = null)
        {
            _logger = logger;
            _aluno = aluno;
        }

        public async Task<IActionResult> Index()
        {
           var x = await _aluno.BuscarAlunoPorId(1);
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