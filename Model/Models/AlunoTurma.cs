using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class AlunoTurma
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; } = string.Empty;
        public int IdTurma { get; set; }
        public string NomeTurma { get; set; } = string.Empty;
    }
}
