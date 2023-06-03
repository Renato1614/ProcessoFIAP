using Microsoft.AspNetCore.Mvc;
using ProcessoFIAP.Services;

namespace ProcessoFIAP.Controllers
{
    public class AlunoTurmaController : Controller
    {
        private readonly IAlunoTurmaService _alunoturmaservice;

        public AlunoTurmaController(IAlunoTurmaService alunoturmaservice)
        {
            _alunoturmaservice = alunoturmaservice;
        }

        public async Task<IActionResult> Index()
        {
            var alunoTurma = await _alunoturmaservice.BuscarTodos();
            return View(alunoTurma);
        }
    }
}
