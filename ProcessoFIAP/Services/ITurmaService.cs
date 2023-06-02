using ProcessoFIAP.Models;

namespace ProcessoFIAP.Services
{
    public interface ITurmaService
    {
        Task<IEnumerable<Turma>> BuscarTurmas();
        Task<bool> CriarTurma(Turma turma);
        Task<Turma> BuscarTurmaPorId(int id);
        Task EditarTurma(Turma turma);
        Task InativarTurma(int id);
        Task<bool> VerificaSeExisteTurmaComOMesmoNome(string nome);
    }
}