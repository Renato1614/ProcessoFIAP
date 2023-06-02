using ProcessoFIAP.Models;

namespace ProcessoFIAP.Services
{
    public interface IAlunoService
    {
        Task<Aluno> BuscarPorId(int id);
        Task<IEnumerable<Aluno>> BuscarTodos();
        Task CriarAluno(Aluno aluno);
        Task EditarAluno(Aluno aluno);
    }
}