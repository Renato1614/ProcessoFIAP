using DataAcess.DbAccess;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class AlunoTurmaData : IAlunoTurmaData
    {
        private readonly IDbDataAcess _db;

        public AlunoTurmaData(IDbDataAcess db)
        {
            _db = db;
        }

        public Task<IEnumerable<AlunoTurma>> BuscarTodos()
        {
            return _db.LoadData<AlunoTurma, dynamic>("dbo.BuscarTodosAlunosDeTurmas", new { });
        }
    }
}
