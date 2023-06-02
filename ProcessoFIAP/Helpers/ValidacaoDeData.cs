namespace ProcessoFIAP.Helpers
{
    public static class ValidacaoDeData
    {
        public static bool ValidaAno(int ano)
        {
            var anoAtual = DateTime.Now.Year;
            if (ano < anoAtual)
            {
                return false;
            }
            return true;
        }
    }
}
