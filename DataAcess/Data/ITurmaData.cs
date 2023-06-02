using ProcessoFIAP.Models;

namespace DataAcess.Data
{
    public interface ITurmaData
    {
        Task<IEnumerable<Turma>> BuscarTurmas();
    }
}