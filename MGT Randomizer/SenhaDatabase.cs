using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGT_Randomizer
{
    class SenhaDatabase
    {
        public static bool SenhasBD(string v)
        {
            if (v == "loli>milf")
            { new PegarQuery().ExecutarQuery(1); return true; }

            else if (v == "loliforall")
            { new PegarQuery().ExecutarQuery(2); return true; }

            else if (v == "loliisthebest")
            { new PegarQuery().ExecutarQuery(3); return true; }

            else if (v == "loliismaiwaifu")
            { new PegarQuery().ExecutarQuery(4); return true; }

            else if (v == "")
            { MessageBox.Show("Digite a senha"); return false; }

            else { MessageBox.Show("Senha invalida!"); return false; }
        }
    }
}
