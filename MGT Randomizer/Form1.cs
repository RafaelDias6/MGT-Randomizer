using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGT_Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Caminho = AppDomain.CurrentDomain.BaseDirectory;
        }
        public static string Caminho { get; private set; }

        private void Randomize_Click(object sender, EventArgs e)
        {
            if (SenhaDatabase.SenhasBD(Senha.Text) != true) { return; }
            if (PegarQuery.X > 0) { Atualizar(); LinkDownload(); CriarTexto(); }
        }
        private void Atualizar()
        {
            jogoTableAdapter.FillBy(dataDataSet.Jogo, PegarQuery.X);
            plataformaTableAdapter.FillBy(dataDataSet.Plataforma, PegarQuery.X);
            generoTableAdapter.FillBy(dataDataSet.Genero, PegarQuery.X);
            poolTableAdapter.FillBy(dataDataSet.Pool, PegarQuery.X);
        }
        private void LinkDownload()
        {
            if (checkLink.Checked && !string.IsNullOrWhiteSpace(DownloadBox.Text))
            {
                Clipboard.SetText(DownloadBox.Text);
            }
            else if (checkLink.Checked && string.IsNullOrWhiteSpace(DownloadBox.Text))
            {
                MessageBox.Show("Sem link para download.");
            }
        }
        private void CriarTexto()
        {
            if (CheckTxt.Checked && !string.IsNullOrEmpty(jogoTextBox.Text))
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                File.WriteAllText(path + @"\OBS.Jogo.txt", jogoTextBox.Text);
                File.WriteAllText(path + @"\OBS.Tempo.txt", tempoTextBox.Text);
                File.WriteAllText(path + @"\OBS.Objetivo.txt", objetivoTextBox.Text);
                File.WriteAllText(path + @"\OBS.Plataforma.txt", plataformaTextBox.Text);
            }
        }
        private void Sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido para o torneio MGT 2018 da SpeedrunsBrasil.",
                            "Sobre");
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente sair?",
                                                   "Sair", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
