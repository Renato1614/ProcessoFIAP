using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace ProcessoFIAP.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }= string.Empty;
        public string Usuario { get; set; }= string.Empty;
        public string Senha { get; set; }= string.Empty;
    }
}