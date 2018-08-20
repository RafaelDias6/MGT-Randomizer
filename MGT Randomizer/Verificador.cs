using System;
namespace MGT_Randomizer
{
    static class Verificador
    {
        //Essa classe serve para pegar o texto até um
        //determinado caractere da sua escolha, criando 
        //a possibilidade de pegar apenas o jogo_id da blacklist.txt
        public static string PegarAte(this string texto, string ateh = "$")
        {
            if (!String.IsNullOrWhiteSpace(texto))
            {
                int caractere = texto.IndexOf(ateh, StringComparison.Ordinal);
                if (caractere > 0)
                {
                    return texto.Substring(0, caractere);
                }
            }
            return String.Empty;
        }
        public static int JogoSelecionado { get; set; }
    }
        
}
