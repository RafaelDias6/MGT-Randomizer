namespace MGT_Randomizer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label jogoLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label objetivoLabel;
            System.Windows.Forms.Label testerLabel;
            System.Windows.Forms.Label tempoLabel;
            System.Windows.Forms.Label poolLabel;
            System.Windows.Forms.Label plataformaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Randomize = new System.Windows.Forms.Button();
            this.Sobre = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.Senha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.CheckTxt = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jogoTextBox = new System.Windows.Forms.TextBox();
            this.jogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new MGT_Randomizer.DataDataSet();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objetivoTextBox = new System.Windows.Forms.TextBox();
            this.testerTextBox = new System.Windows.Forms.TextBox();
            this.tempoTextBox = new System.Windows.Forms.TextBox();
            this.poolTextBox = new System.Windows.Forms.TextBox();
            this.poolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plataformaTextBox = new System.Windows.Forms.TextBox();
            this.plataformaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkLink = new System.Windows.Forms.CheckBox();
            this.jogoTableAdapter = new MGT_Randomizer.DataDataSetTableAdapters.JogoTableAdapter();
            this.tableAdapterManager = new MGT_Randomizer.DataDataSetTableAdapters.TableAdapterManager();
            this.generoTableAdapter = new MGT_Randomizer.DataDataSetTableAdapters.GeneroTableAdapter();
            this.plataformaTableAdapter = new MGT_Randomizer.DataDataSetTableAdapters.PlataformaTableAdapter();
            this.poolTableAdapter = new MGT_Randomizer.DataDataSetTableAdapters.PoolTableAdapter();
            this.DownloadBox = new System.Windows.Forms.TextBox();
            jogoLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            objetivoLabel = new System.Windows.Forms.Label();
            testerLabel = new System.Windows.Forms.Label();
            tempoLabel = new System.Windows.Forms.Label();
            poolLabel = new System.Windows.Forms.Label();
            plataformaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataformaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jogoLabel
            // 
            jogoLabel.AutoSize = true;
            jogoLabel.Location = new System.Drawing.Point(155, 7);
            jogoLabel.Name = "jogoLabel";
            jogoLabel.Size = new System.Drawing.Size(43, 17);
            jogoLabel.TabIndex = 8;
            jogoLabel.Text = "Jogo:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(137, 35);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(60, 17);
            generoLabel.TabIndex = 9;
            generoLabel.Text = "Genero:";
            // 
            // objetivoLabel
            // 
            objetivoLabel.AutoSize = true;
            objetivoLabel.Location = new System.Drawing.Point(133, 63);
            objetivoLabel.Name = "objetivoLabel";
            objetivoLabel.Size = new System.Drawing.Size(64, 17);
            objetivoLabel.TabIndex = 11;
            objetivoLabel.Text = "Objetivo:";
            // 
            // testerLabel
            // 
            testerLabel.AutoSize = true;
            testerLabel.Location = new System.Drawing.Point(137, 91);
            testerLabel.Name = "testerLabel";
            testerLabel.Size = new System.Drawing.Size(60, 17);
            testerLabel.TabIndex = 13;
            testerLabel.Text = "Testers:";
            // 
            // tempoLabel
            // 
            tempoLabel.AutoSize = true;
            tempoLabel.Location = new System.Drawing.Point(371, 91);
            tempoLabel.Name = "tempoLabel";
            tempoLabel.Size = new System.Drawing.Size(36, 17);
            tempoLabel.TabIndex = 15;
            tempoLabel.Text = "Est.:";
            // 
            // poolLabel
            // 
            poolLabel.AutoSize = true;
            poolLabel.Location = new System.Drawing.Point(158, 119);
            poolLabel.Name = "poolLabel";
            poolLabel.Size = new System.Drawing.Size(40, 17);
            poolLabel.TabIndex = 17;
            poolLabel.Text = "Pool:";
            // 
            // plataformaLabel
            // 
            plataformaLabel.AutoSize = true;
            plataformaLabel.Location = new System.Drawing.Point(309, 35);
            plataformaLabel.Name = "plataformaLabel";
            plataformaLabel.Size = new System.Drawing.Size(80, 17);
            plataformaLabel.TabIndex = 19;
            plataformaLabel.Text = "Plataforma:";
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(140, 144);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(376, 32);
            this.Randomize.TabIndex = 0;
            this.Randomize.Text = "Randomize";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // Sobre
            // 
            this.Sobre.Location = new System.Drawing.Point(307, 177);
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(104, 28);
            this.Sobre.TabIndex = 1;
            this.Sobre.Text = "Sobre";
            this.Sobre.UseVisualStyleBackColor = true;
            this.Sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(417, 177);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(99, 28);
            this.Sair.TabIndex = 2;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(380, 117);
            this.Senha.MaxLength = 20;
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(133, 22);
            this.Senha.TabIndex = 3;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(321, 120);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(53, 17);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha:";
            // 
            // CheckTxt
            // 
            this.CheckTxt.AutoSize = true;
            this.CheckTxt.Checked = true;
            this.CheckTxt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckTxt.Location = new System.Drawing.Point(145, 183);
            this.CheckTxt.Name = "CheckTxt";
            this.CheckTxt.Size = new System.Drawing.Size(89, 21);
            this.CheckTxt.TabIndex = 5;
            this.CheckTxt.Text = "Gerar .txt";
            this.CheckTxt.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-38, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // jogoTextBox
            // 
            this.jogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogoBindingSource, "jogo", true));
            this.jogoTextBox.Location = new System.Drawing.Point(200, 4);
            this.jogoTextBox.Name = "jogoTextBox";
            this.jogoTextBox.ReadOnly = true;
            this.jogoTextBox.Size = new System.Drawing.Size(314, 22);
            this.jogoTextBox.TabIndex = 9;
            // 
            // jogoBindingSource
            // 
            this.jogoBindingSource.DataMember = "Jogo";
            this.jogoBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoTextBox
            // 
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generoBindingSource, "genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(200, 32);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.ReadOnly = true;
            this.generoTextBox.Size = new System.Drawing.Size(105, 22);
            this.generoTextBox.TabIndex = 10;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.dataDataSet;
            // 
            // objetivoTextBox
            // 
            this.objetivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogoBindingSource, "objetivo", true));
            this.objetivoTextBox.Location = new System.Drawing.Point(200, 60);
            this.objetivoTextBox.Name = "objetivoTextBox";
            this.objetivoTextBox.ReadOnly = true;
            this.objetivoTextBox.Size = new System.Drawing.Size(314, 22);
            this.objetivoTextBox.TabIndex = 12;
            // 
            // testerTextBox
            // 
            this.testerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogoBindingSource, "tester", true));
            this.testerTextBox.Location = new System.Drawing.Point(200, 88);
            this.testerTextBox.Name = "testerTextBox";
            this.testerTextBox.ReadOnly = true;
            this.testerTextBox.Size = new System.Drawing.Size(165, 22);
            this.testerTextBox.TabIndex = 14;
            // 
            // tempoTextBox
            // 
            this.tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogoBindingSource, "tempo", true));
            this.tempoTextBox.Location = new System.Drawing.Point(414, 88);
            this.tempoTextBox.Name = "tempoTextBox";
            this.tempoTextBox.ReadOnly = true;
            this.tempoTextBox.Size = new System.Drawing.Size(100, 22);
            this.tempoTextBox.TabIndex = 16;
            // 
            // poolTextBox
            // 
            this.poolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poolBindingSource, "pool", true));
            this.poolTextBox.Location = new System.Drawing.Point(200, 116);
            this.poolTextBox.Name = "poolTextBox";
            this.poolTextBox.ReadOnly = true;
            this.poolTextBox.Size = new System.Drawing.Size(115, 22);
            this.poolTextBox.TabIndex = 18;
            // 
            // poolBindingSource
            // 
            this.poolBindingSource.DataMember = "Pool";
            this.poolBindingSource.DataSource = this.dataDataSet;
            // 
            // plataformaTextBox
            // 
            this.plataformaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plataformaBindingSource, "plataforma", true));
            this.plataformaTextBox.Location = new System.Drawing.Point(395, 32);
            this.plataformaTextBox.Name = "plataformaTextBox";
            this.plataformaTextBox.ReadOnly = true;
            this.plataformaTextBox.Size = new System.Drawing.Size(118, 22);
            this.plataformaTextBox.TabIndex = 20;
            // 
            // plataformaBindingSource
            // 
            this.plataformaBindingSource.DataMember = "Plataforma";
            this.plataformaBindingSource.DataSource = this.dataDataSet;
            // 
            // checkLink
            // 
            this.checkLink.AutoSize = true;
            this.checkLink.Checked = true;
            this.checkLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLink.Location = new System.Drawing.Point(244, 183);
            this.checkLink.Name = "checkLink";
            this.checkLink.Size = new System.Drawing.Size(56, 21);
            this.checkLink.TabIndex = 21;
            this.checkLink.Text = "Link";
            this.checkLink.UseVisualStyleBackColor = true;
            // 
            // jogoTableAdapter
            // 
            this.jogoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GeneroTableAdapter = this.generoTableAdapter;
            this.tableAdapterManager.JogoTableAdapter = this.jogoTableAdapter;
            this.tableAdapterManager.PlataformaTableAdapter = this.plataformaTableAdapter;
            this.tableAdapterManager.PoolTableAdapter = this.poolTableAdapter;
            this.tableAdapterManager.UpdateOrder = MGT_Randomizer.DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // plataformaTableAdapter
            // 
            this.plataformaTableAdapter.ClearBeforeFill = true;
            // 
            // poolTableAdapter
            // 
            this.poolTableAdapter.ClearBeforeFill = true;
            // 
            // DownloadBox
            // 
            this.DownloadBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogoBindingSource, "download", true));
            this.DownloadBox.Location = new System.Drawing.Point(5, 183);
            this.DownloadBox.Name = "DownloadBox";
            this.DownloadBox.Size = new System.Drawing.Size(112, 22);
            this.DownloadBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 245);
            this.ControlBox = false;
            this.Controls.Add(this.checkLink);
            this.Controls.Add(plataformaLabel);
            this.Controls.Add(this.plataformaTextBox);
            this.Controls.Add(poolLabel);
            this.Controls.Add(this.poolTextBox);
            this.Controls.Add(tempoLabel);
            this.Controls.Add(this.tempoTextBox);
            this.Controls.Add(testerLabel);
            this.Controls.Add(this.testerTextBox);
            this.Controls.Add(objetivoLabel);
            this.Controls.Add(this.objetivoTextBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoTextBox);
            this.Controls.Add(jogoLabel);
            this.Controls.Add(this.jogoTextBox);
            this.Controls.Add(this.CheckTxt);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Sobre);
            this.Controls.Add(this.Randomize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DownloadBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MGT Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataformaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.Button Sobre;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.CheckBox CheckTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource jogoBindingSource;
        private DataDataSetTableAdapters.JogoTableAdapter jogoTableAdapter;
        private DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox jogoTextBox;
        private DataDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.TextBox objetivoTextBox;
        private System.Windows.Forms.TextBox testerTextBox;
        private System.Windows.Forms.TextBox tempoTextBox;
        private DataDataSetTableAdapters.PoolTableAdapter poolTableAdapter;
        private System.Windows.Forms.BindingSource poolBindingSource;
        private DataDataSetTableAdapters.PlataformaTableAdapter plataformaTableAdapter;
        private System.Windows.Forms.TextBox poolTextBox;
        private System.Windows.Forms.BindingSource plataformaBindingSource;
        private System.Windows.Forms.TextBox plataformaTextBox;
        private System.Windows.Forms.CheckBox checkLink;
        private System.Windows.Forms.TextBox DownloadBox;
        internal System.Windows.Forms.TextBox Senha;
    }
}

