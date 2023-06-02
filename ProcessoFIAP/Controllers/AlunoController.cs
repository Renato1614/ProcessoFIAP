using DataAcess.DbAccess;
using Microsoft.AspNetCore.Mvc;
using ProcessoFIAP.Models;
using ProcessoFIAP.Services;

namespace ProcessoFIAP.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService _alunoservice;

        public AlunoController(IAlunoService alunoservice)
        {
            _alunoservice = alunoservice;
        }

        public async Task<IActionResult> Index()
        {
            var alunos = await _alunoservice.BuscarTodos();
            return View(alunos);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                await _alunoservice.CriarAluno(aluno);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async  Task<IActionResult> Editar(int id)
        {
            var aluno = await _alunoservice.BuscarPorId(id);
            return View(aluno);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                await _alunoservice.EditarAluno(aluno);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
