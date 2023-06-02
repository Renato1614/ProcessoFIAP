using DataAcess.Data;
using DataAcess.DbAccess;
using ProcessoFIAP.Models;

namespace ProcessoFIAP.Services;
public class AlunoService : IAlunoService
{
    private readonly IAlunoData _db;

    public AlunoService(IAlunoData db)
    {
        _db = db;
    }

    public async Task<Aluno> BuscarPorId(int id)
    {
        return await _db.BuscarAlunoPorId(id);
    }

    public async Task<IEnumerable<Aluno>> BuscarTodos()
    {
        return await _db.BuscarTodosOsAlunos();
    }

    public async Task CriarAluno(Aluno aluno)
    {
        await _db.CriarAluno(aluno);
    }

    public async  Task EditarAluno(Aluno aluno)
    {
        await _db.EditarAluno(aluno);
    }
}
