using ProcessoFIAP.Models;

namespace DataAcess.Data
{
    public interface IAlunoData
    {
        Task<IEnumerable<Aluno>> BuscarTodosOsAlunos();
        Task<Aluno> BuscarAlunoPorId(int id);
        Task CriarAluno(Aluno aluno);
        Task EditarAluno(Aluno aluno);
    }
}