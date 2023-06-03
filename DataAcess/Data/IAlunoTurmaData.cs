using Model.Models;

namespace DataAcess.Data
{
    public interface IAlunoTurmaData
    {
        Task<AlunoTurma> BuscarAlunoTurmaComIdDoAlunoEIdDaTurma(int idAluno, int idTurma);
        Task<IEnumerable<AlunoTurma>> BuscarTodos();
        Task InativarRelacionamento(int id);
        Task RelacionarAlunoComTurma(int idAluno, int idTurma);
    }
}