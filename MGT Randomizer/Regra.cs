using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGT_Randomizer
{
    static class Regra
    {
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
