using DataAcess.Data;
using DataAcess.DbAccess;
using ProcessoFIAP.Models;

namespace ProcessoFIAP.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaData _db;

        public TurmaService(ITurmaData db)
        {
            _db = db;
        }

        public async Task<Turma> BuscarTurmaPorId(int id)
        {
            return await _db.BuscarTurmaPorId(id);
        }

        public async Task<bool> VerificaSeExisteTurmaComOMesmoNome(string nome)
        {
            var turma = await _db.BuscarTurmaPorNome(nome);
            return turma != null;
        }

        public async Task<IEnumerable<Turma>> BuscarTurmas()
        {
            return await _db.BuscarTurmas();
        }

        public async Task CriarTurma(Turma turma)
        {
            await _db.CriarTurma(turma);
        }

        public async Task EditarTurma(Turma turma)
        {
            await _db.EditarTurma(turma);
        }

        public async Task InativarTurma(int id)
        {
            await _db.InativarTurma(id);
        }
    }
}
