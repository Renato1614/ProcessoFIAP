using Microsoft.AspNetCore.Mvc;
using ProcessoFIAP.Helpers;
using ProcessoFIAP.Models;
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
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Turma turma)
        {
            if (ModelState.IsValid)
            {
                if (await VerificaCondicoesDeRegradeAnoENomeDaTurma(turma))
                {
                    await _turma.CriarTurma(turma);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(turma);
        }

        public async Task<IActionResult> Editar(int id)
        {
            var turma = await _turma.BuscarTurmaPorId(id);
            return View(turma);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Turma turma)
        {
            if (ModelState.IsValid)
            {
                if (await VerificaCondicoesDeRegradeAnoENomeDaTurma(turma))
                {
                    await _turma.EditarTurma(turma);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(turma);
        }

        [HttpPost]
        public async Task<bool> Inativar(int? id)
        {
            if (id != null)
            {
                await _turma.InativarTurma(id.Value);
                return true;
            }
            return false;
        }

        #region metodos privados
        private bool VerificaAno(int ano)
        {
            if (!ValidacaoDeData.ValidaAno(ano))
            {
                ModelState.AddModelError("AnoInvalido", "O ano não pode ser menor do que o ano atual");
                return false;
            }
            return true;
        }

        private async Task<bool> VerificaTurmaDuplicada(string nome)
        {
            if (await _turma.VerificaSeExisteTurmaComOMesmoNome(nome))
            {
                ModelState.AddModelError("NomeDuplicado", "Não pode ter mais de 1 turma com o mesmo nome");
                return false;
            }
            return true;
        }
        private async Task<bool> VerificaCondicoesDeRegradeAnoENomeDaTurma(Turma turma)
        {
            return VerificaAno(turma.Ano) && await VerificaTurmaDuplicada(turma.Nome);
        }

        #endregion

    }
}
