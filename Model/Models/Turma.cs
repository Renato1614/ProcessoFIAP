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
        [Display(Name ="Numero do curso")]
        public int CursoId { get; set; }
        public string Nome { get; set; }=string.Empty;
        public int Ano { get; set; }
        public bool Status { get; set; }
    }
}