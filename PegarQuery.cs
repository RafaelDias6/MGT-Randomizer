using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MGT_Randomizer
{
    class PegarQuery
    {
        private string Comando;
        public static int X { get; private set; }
        public static int B
        { get; private set; }
        public void ExecutarQuery(int v)
        {
            //****************Lista de variaveis****************
            List<string> ListaNegra = new List<string>(); //Lista negra de jogos que já foram sorteados
            List<string> resultado = new List<string>(); // Cria lista a partir do num_jogo removendo exceções que estão na variavel ListaNegra
            List<string> num_jogo = new List<string>(); //Lista dos "jogo_id" do BD (Banco de dados)
            SqlCommand cmd = null; //Execução da consulta do BD
            SqlDataReader rdr = null;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;
                                                    AttachDbFilename=|DataDirectory|\Data.mdf;
                                                    Integrated Security=True;
                                                    Connect Timeout=5");
            /* Com a variável "con" é possível direcionar para outro BD se necessitar. 
             * Com um pouco de google acho que dá para se virar. 
             *****************************************************/
            con.Open(); //Conexão com o servidor (Banco de Dados)
            Consulta(v); //comando da consulta (query)
            cmd = new SqlCommand(Comando);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader(); //Var onde irá ficar locada as informações da Query
            while (rdr.Read())
            {
                num_jogo.Add(rdr["jogo_id"].ToString() +
                             "$" + rdr["jogo"].ToString());//Salvar resultado da query em lista
            }
            //********************************************************************

            var drive = Updater.Credencial(); //Abre a conexão com serviço do drive
            Updater.Download(drive); //Baixa blacklist.txt

            if (File.Exists(Form1.Caminho + @"/Blacklist.txt")) //Checa se existe blacklist.txt
            {
                ListaNegra = File.ReadAllLines(Form1.Caminho +
                    @"\Blacklist.txt").ToList(); //Leitor do Blacklist.txt
                resultado = num_jogo.Except(ListaNegra).ToList();//Exclusão das entries num_jogo que possui na Blacklist
            }
            //********************************************************************
            Random rnd = new Random(); //Método de aleatoriedade do .net
            if (resultado.Any())//Se resultado não for nulo
            {
                X = resultado.Count;//Contagem de entradas no resultado
                X = rnd.Next(1, X);//Selecionar de 1 até nº de entradas do resultado
                string Texto = resultado[X - 1] + Environment.NewLine; //x-1 por Array começar em 0
                File.AppendAllText(Form1.Caminho + @"\Blacklist.txt", Texto, Encoding.UTF8);//Serve para adcionar texto no arquivo
                
                X = Convert.ToInt32(Texto.PegarAte());//Método para pegar apenas o jogo_id no blacklist.txt
                Regra.JogoSelecionado = X;
            }
            else { MessageBox.Show("Não há mais jogos nessa Pool"); X = 0; }//x=0 para utilizar-lo como verificador no form1
            con.Close();

            Updater.Upload(drive); // Faz o upload do blacklist.txt atualizado para o drive
        }
        private void Consulta(int v)
        {
            if (v == 1 || v == 2 || v == 3)
            {
                Comando = "SELECT jogo_id, jogo" +
                    "  FROM Jogo" +
                    " WHERE pool =" + v;
            }
            if (v == 4)
            {
                Comando = "SELECT jogo_id, jogo" +
                    "  FROM Jogo";
            }
        }
    }
}
