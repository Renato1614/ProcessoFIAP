using Microsoft.AspNetCore.Mvc;
using ProcessoFIAP.Services;

namespace ProcessoFIAP.Controllers
{
    public class TurmaController : Controller
    {
        private readonly ITurmaService _turma;

        public TurmaController(ITurmaService turma)
        {
            _turma = turma;
        }

        public async Task<IActionResult> Index()
        {
            var turmas = await _turma.BuscarTurmas();
            return View(turmas);
        }
    }
}
