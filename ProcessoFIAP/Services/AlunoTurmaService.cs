using DataAcess.Data;
using Model.Models;

namespace ProcessoFIAP.Services
{
    public class AlunoTurmaService : IAlunoTurmaService
    {
        private readonly IAlunoTurmaData _alunoturma;

        public AlunoTurmaService(IAlunoTurmaData alunoturma)
        {
            _alunoturma = alunoturma;
        }

        public async Task<IEnumerable<AlunoTurma>> BuscarTodos()
        {
            return await _alunoturma.BuscarTodos();
        }

        public async Task<bool> VerificarSeAlunoJaEstaNaTurma(int idAluno, int idTurma)
        {
            try
            {
                var AlunoNaTurma = await _alunoturma.BuscarAlunoTurmaComIdDoAlunoEIdDaTurma(idAluno, idTurma);
                return AlunoNaTurma == null;
            }
            catch (Exception e )
            {

                throw new Exception(e.Message);
            }

        }

        public async Task<bool> RelacionarAlunoComTurma(int idAluno, int idTurma)
        {
            if (await VerificarSeAlunoJaEstaNaTurma(idAluno,idTurma))
            {
                await _alunoturma.RelacionarAlunoComTurma(idAluno,idTurma);
                return true;
            }
            return false;
        }

        public async Task<bool> InativarAlunoTurma(int id)
        {
            try
            {
                await _alunoturma.InativarRelacionamento(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
