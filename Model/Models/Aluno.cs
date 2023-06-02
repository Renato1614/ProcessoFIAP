
using System.ComponentModel.DataAnnotations;

namespace ProcessoFIAP.Models;
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }= string.Empty;
    public string Usuario { get; set; } = string.Empty;
    [DataType(DataType.Password)]
    public string Senha { get; set; } = string.Empty;
    public bool? Status { get; set; }
}