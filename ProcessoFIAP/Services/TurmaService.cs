using DataAcess.Data;
using DataAcess.DbAccess;
using ProcessoFIAP.Models;

namespace ProcessoFIAP.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaData _db;

        public TurmaService(ITurmaData db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Turma>> BuscarTurmas()
        {
            return await _db.BuscarTurmas();
        }
    }
}
