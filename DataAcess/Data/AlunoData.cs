using DataAcess.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class AlunoData
    {
        IDbDataAcess _sql;

        public AlunoData(IDbDataAcess sql)
        {
            _sql = sql;
        }

        public Task<IEnumerable<AlunoData>> GetAlunos()
        {
            return _sql.LoadData<AlunoData,dynamic>("dbo.GetAllAlunos", new { });
        }
    }
}
