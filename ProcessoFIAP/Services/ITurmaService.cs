using ProcessoFIAP.Models;

namespace ProcessoFIAP.Services
{
    public interface ITurmaService
    {
        Task<IEnumerable<Turma>> BuscarTurmas();
        Task CriarTurma(Turma turma);
    }
}