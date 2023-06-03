using Microsoft.AspNetCore.Mvc;
using ProcessoFIAP.Services;

namespace ProcessoFIAP.Controllers
{
    public class AlunoTurmaController : Controller
    {
        private readonly IAlunoTurmaService _alunoturmaservice;
        private readonly IAlunoService _alunoservice;
        private readonly ITurmaService _turmaservice;
        public AlunoTurmaController(IAlunoTurmaService alunoturmaservice, IAlunoService alunoservice, ITurmaService turmaservice)
        {
            _alunoturmaservice = alunoturmaservice;
            _alunoservice = alunoservice;
            _turmaservice = turmaservice;
        }

        public async Task<IActionResult> Index()
        {
            var alunoTurma = await _alunoturmaservice.BuscarTodos();
            return View(alunoTurma);
        }

        public async Task<IActionResult> Criar()
        {
            ViewData["Alunos"] = await _alunoservice.BuscarTodos();
            ViewData["Turmas"] = await _turmaservice.BuscarTurmas();
            return View();
        }

        [HttpPost]
        public async Task<bool> Criar(int idAluno,int idTurma)
        {
            var result = await _alunoturmaservice.RelacionarAlunoComTurma(idAluno, idTurma);
            return result;
        }

        [HttpPost]
        public async Task<bool> Inativar(int id)
        {
            bool result = await _alunoturmaservice.InativarAlunoTurma(id);
            return result;
        }
    }
}
