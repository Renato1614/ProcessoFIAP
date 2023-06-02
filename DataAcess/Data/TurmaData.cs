using DataAcess.DbAccess;
using ProcessoFIAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class TurmaData : ITurmaData
    {
        private readonly IDbDataAcess _db;

        public TurmaData(IDbDataAcess db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Turma>> BuscarTurmas()
        {
            try
            {
                return await _db.LoadData<Turma, dynamic>("dbo.BuscarTodasAsTurmasAtivas", new { });

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
