using DataAcess.DbAccess;
using ProcessoFIAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class AlunoData : IAlunoData
    {
        private readonly IDbDataAcess _sql;

        public AlunoData(IDbDataAcess sql)
        {
            _sql = sql;
        }

        public async Task CriarAluno(Aluno aluno)
        {
            try
            {
                await _sql.SaveData(
                    "dbo.CriarAluno",
                    new { aluno.Nome, aluno.Usuario, aluno.Senha, Status = 1 });
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task EditarAluno(Aluno aluno)
        {
            try
            {
                await _sql.SaveData(
                   StoredProcudure: "dbo.EditarAluno",
                    aluno);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<Aluno?> BuscarAlunoPorId(int id)
        {
            try
            {
                var result = await _sql.LoadData<Aluno, dynamic>("dbo.BuscarAlunoPorId", new { Id = id });
                var primeiro = result.FirstOrDefault();
                return primeiro;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<Aluno>> BuscarTodosOsAlunos()
        {
            try
            {
                return await _sql.LoadData<Aluno, dynamic>("dbo.BuscarTodosOsAlunosAtivos", new { });

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task InativarAluno(int id)
        {
            try
            {
                await _sql.SaveData(
                   StoredProcudure: "dbo.InativarAluno",
                    new {Id=id});
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
