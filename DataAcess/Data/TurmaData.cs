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

        public async  Task<Turma> BuscarTurmaPorId(int id)
        {
            try
            {
                var turma =  await _db.LoadData<Turma, dynamic>("dbo.BuscarTurmaPorId", new {id=id });
                return turma.FirstOrDefault();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<Turma> BuscarTurmaPorNome(string nome)
        {
            try
            {
                var turma = await _db.LoadData<Turma, dynamic>("dbo.BuscarTurmaPorNome", new { nome = nome });
                return turma.FirstOrDefault();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
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

        public async Task CriarTurma(Turma turma)
        {
            await _db.SaveData("dbo.CriarTurma", 
                new { turma.CursoId,turma.Nome,turma.Ano});
        }

        public async Task EditarTurma(Turma turma)
        {
            await _db.SaveData("dbo.EditarTurma", turma);
        }

        public async Task InativarTurma(int id)
        {
            await _db.SaveData("dbo.InativarTurma", new { id });
        }
    }
}
