
using System.ComponentModel.DataAnnotations;

namespace ProcessoFIAP.Models;
public class Aluno
{
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }= string.Empty;
    [Required]
    public string Usuario { get; set; } = string.Empty;
    [Required]
    public string Senha { get; set; } = string.Empty;
    public bool Status { get; set; }
}