using Model.Models;

namespace ProcessoFIAP.Services
{
    public interface IAlunoTurmaService
    {
        Task<IEnumerable<AlunoTurma>> BuscarTodos();
    }
}