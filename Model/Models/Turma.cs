using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessoFIAP.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public string TurmaNome { get; set; }=string.Empty;
        public int Ano { get; set; }
    }
}