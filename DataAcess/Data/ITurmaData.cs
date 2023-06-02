using ProcessoFIAP.Models;

namespace DataAcess.Data
{
    public interface ITurmaData
    {
        Task<Turma> BuscarTurmaPorId(int id);
        Task<Turma> BuscarTurmaPorNome(string nome);
        Task<IEnumerable<Turma>> BuscarTurmas();
        Task CriarTurma(Turma turma);
        Task EditarTurma(Turma turma);
        Task InativarTurma(int id);
    }
}