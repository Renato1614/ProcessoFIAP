using DataAcess.DbAccess;
using Microsoft.AspNetCore.Mvc;
using ProcessoFIAP.Helpers;
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
                if (VerificaSenhaValida(aluno.Senha))
                {
                    aluno.Senha = CriptografarSenha(aluno.Senha);
                    await _alunoservice.CriarAluno(aluno);
                }
                else
                {
                    ModelState.AddModelError("SenhaForte", "A Senha precisa conter Letras maiusculas, minusculas, numeros e caracteres especiais");
                    return View();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int id)
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
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        [HttpPost]
        public async Task<bool> Inativar(int? id)
        {
            if (id != null)
            {
                await _alunoservice.InativarAluno(id.Value);
                return true;
            }
            return false;
        }

        private string CriptografarSenha(string senha)
        {
            var criptografar = new CriptografiaDeSenha(senha);
            return criptografar.CriptografarSenha();
        }
        private bool VerificaSenhaValida(string senha)
        {
            var verificaSenha = new VerificacaoDeSenha(senha);
            return verificaSenha.VerificaSenhaForte();

        }
    }
}
