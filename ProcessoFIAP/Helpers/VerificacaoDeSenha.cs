using System.Runtime.CompilerServices;

namespace ProcessoFIAP.Helpers;

public class VerificacaoDeSenha
{
    public string Senha { get; set; }

    public VerificacaoDeSenha(string senha)
    {
        Senha = senha;
    }

    public bool VerificaSenhaForte()
    {
        // Verifica o comprimento mínimo
        if (this.Senha.Length < 8)
            return false;

        // Verifica se há letras maiúsculas, minúsculas, números e caracteres especiais
        bool hasUpperCase = this.Senha.Any(char.IsUpper);
        bool hasLowerCase = this.Senha.Any(char.IsLower);
        bool hasDigit = this.Senha.Any(char.IsDigit);
        bool hasSpecialChar = this.Senha.Any(VerificaCaracteresEspeciais);

        if (!hasUpperCase || !hasLowerCase || !hasDigit || !hasSpecialChar)
            return false;

        // Verifica se a senha contém sequências ou padrões
        if (VerificaSequencia() || VerificaRepeticao())
            return false;

        return true;
    }

    private bool VerificaCaracteresEspeciais(char c)
    {
        return !char.IsLetterOrDigit(c);
    }

    private bool VerificaSequencia()
    {
        // Verifica se a senha contém sequências como "abcd" ou "1234"
        for (int i = 0; i < this.Senha.Length - 3; i++)
        {
            if (this.Senha[i] + 1 == this.Senha[i + 1] && this.Senha[i + 1] + 1 == this.Senha[i + 2] && this.Senha[i + 2] + 1 == this.Senha[i + 3])
                return true;
        }

        return false;
    }

    private bool VerificaRepeticao()
    {
        // Verifica se a senha contém repetições de caracteres
        for (int i = 0; i < this.Senha.Length - 2; i++)
        {
            if (this.Senha[i] == this.Senha[i + 1] && this.Senha[i + 1] == this.Senha[i + 2])
                return true;
        }

        return false;
    }
}
