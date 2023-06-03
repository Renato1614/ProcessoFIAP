using Model.Models;

namespace ProcessoFIAP.Services
{
    public interface IAlunoTurmaService
    {
        Task<IEnumerable<AlunoTurma>> BuscarTodos();
        Task<bool> InativarAlunoTurma(int id);
        Task<bool> RelacionarAlunoComTurma(int idAluno, int idTurma);
        Task<bool> VerificarSeAlunoJaEstaNaTurma(int idAluno, int idTurma);
    }
}