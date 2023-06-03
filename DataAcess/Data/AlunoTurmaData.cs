using DataAcess.DbAccess;
using Model.Models;
using ProcessoFIAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public async Task<AlunoTurma> BuscarAlunoTurmaComIdDoAlunoEIdDaTurma(int idAluno, int idTurma)
        {
            var verificacao= await _db.LoadData<AlunoTurma, dynamic>("dbo.BuscarAlunoTurmaComIdDoAlunoEIdDaTurma", new {idAluno,idTurma });
            return verificacao.FirstOrDefault();

        }

        public async Task<IEnumerable<AlunoTurma>> BuscarTodos()
        {
            return await _db.LoadData<AlunoTurma, dynamic>("dbo.BuscarTodosAlunosDeTurmas", new { });
        }

        public async Task InativarRelacionamento(int id)
        {
            await _db.SaveData("dbo.InativarRelacionamento", new { Id =id });
        }

        public async Task RelacionarAlunoComTurma(int idAluno, int idTurma)
        {
            await _db.SaveData("dbo.RelacionarAlunoComTurma", new { idAluno, idTurma });
        }
    }
}
