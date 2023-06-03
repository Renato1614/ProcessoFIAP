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
    }
}
