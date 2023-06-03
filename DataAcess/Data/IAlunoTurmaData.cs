using Model.Models;

namespace DataAcess.Data
{
    public interface IAlunoTurmaData
    {
        Task<IEnumerable<AlunoTurma>> BuscarTodos();
    }
}