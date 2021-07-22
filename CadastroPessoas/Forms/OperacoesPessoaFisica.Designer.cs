
namespace Forms
{
    partial class OperacoesPessoaFisica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txPessoaFNome = new System.Windows.Forms.TextBox();
            this.lbPessoaFNome = new System.Windows.Forms.Label();
            this.lbEditavel = new System.Windows.Forms.Label();
            this.lbPessoaFDataNascimento = new System.Windows.Forms.Label();
            this.lbPessoaFCpf = new System.Windows.Forms.Label();
            this.txPessoaFCpf = new System.Windows.Forms.TextBox();
            this.lbPessoaFRg = new System.Windows.Forms.Label();
            this.txPessoaFRg = new System.Windows.Forms.TextBox();
            this.lbPessoaFEndereco = new System.Windows.Forms.Label();
            this.lbPessoaFCidade = new System.Windows.Forms.Label();
            this.txPessoaFCidade = new System.Windows.Forms.TextBox();
            this.lbPessoaFBairro = new System.Windows.Forms.Label();
            this.txPessoaFBairro = new System.Windows.Forms.TextBox();
            this.lbPessoaFRua = new System.Windows.Forms.Label();
            this.txPessoaFRua = new System.Windows.Forms.TextBox();
            this.lbPessoaFNumero = new System.Windows.Forms.Label();
            this.txPessoaFNumero = new System.Windows.Forms.TextBox();
            this.lbPessoaFComplemento = new System.Windows.Forms.Label();
            this.txPessoaFComplemento = new System.Windows.Forms.TextBox();
            this.lvPessoaFLista = new System.Windows.Forms.ListView();
            this.btPessoaFSalvar = new System.Windows.Forms.Button();
            this.btPessoaFVoltar = new System.Windows.Forms.Button();
            this.btPessoaFLimpar = new System.Windows.Forms.Button();
            this.dtPessoaFDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.Rua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_de_Nascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Número = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Complemento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txPessoaFNome
            // 
            this.txPessoaFNome.Location = new System.Drawing.Point(141, 80);
            this.txPessoaFNome.Name = "txPessoaFNome";
            this.txPessoaFNome.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFNome.TabIndex = 0;
            this.txPessoaFNome.TextChanged += new System.EventHandler(this.txPessoaFNome_TextChanged);
            // 
            // lbPessoaFNome
            // 
            this.lbPessoaFNome.AutoSize = true;
            this.lbPessoaFNome.Location = new System.Drawing.Point(28, 83);
            this.lbPessoaFNome.Name = "lbPessoaFNome";
            this.lbPessoaFNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFNome.Size = new System.Drawing.Size(38, 13);
            this.lbPessoaFNome.TabIndex = 5;
            this.lbPessoaFNome.Text = "Nome:";
            this.lbPessoaFNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEditavel
            // 
            this.lbEditavel.AutoSize = true;
            this.lbEditavel.BackColor = System.Drawing.Color.Transparent;
            this.lbEditavel.ForeColor = System.Drawing.Color.Black;
            this.lbEditavel.Location = new System.Drawing.Point(355, 30);
            this.lbEditavel.Name = "lbEditavel";
            this.lbEditavel.Size = new System.Drawing.Size(74, 13);
            this.lbEditavel.TabIndex = 10;
            this.lbEditavel.Text = "Pessoa Física";
            // 
            // lbPessoaFDataNascimento
            // 
            this.lbPessoaFDataNascimento.AutoSize = true;
            this.lbPessoaFDataNascimento.Location = new System.Drawing.Point(28, 109);
            this.lbPessoaFDataNascimento.Name = "lbPessoaFDataNascimento";
            this.lbPessoaFDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbPessoaFDataNascimento.TabIndex = 12;
            this.lbPessoaFDataNascimento.Text = "Data de Nascimento:";
            this.lbPessoaFDataNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPessoaFCpf
            // 
            this.lbPessoaFCpf.AutoSize = true;
            this.lbPessoaFCpf.Location = new System.Drawing.Point(28, 161);
            this.lbPessoaFCpf.Name = "lbPessoaFCpf";
            this.lbPessoaFCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFCpf.Size = new System.Drawing.Size(30, 13);
            this.lbPessoaFCpf.TabIndex = 16;
            this.lbPessoaFCpf.Text = "CPF:";
            this.lbPessoaFCpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFCpf
            // 
            this.txPessoaFCpf.Location = new System.Drawing.Point(141, 158);
            this.txPessoaFCpf.Name = "txPessoaFCpf";
            this.txPessoaFCpf.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFCpf.TabIndex = 15;
            // 
            // lbPessoaFRg
            // 
            this.lbPessoaFRg.AutoSize = true;
            this.lbPessoaFRg.Location = new System.Drawing.Point(28, 135);
            this.lbPessoaFRg.Name = "lbPessoaFRg";
            this.lbPessoaFRg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFRg.Size = new System.Drawing.Size(26, 13);
            this.lbPessoaFRg.TabIndex = 14;
            this.lbPessoaFRg.Text = "RG:";
            this.lbPessoaFRg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFRg
            // 
            this.txPessoaFRg.Location = new System.Drawing.Point(141, 132);
            this.txPessoaFRg.Name = "txPessoaFRg";
            this.txPessoaFRg.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFRg.TabIndex = 13;
            // 
            // lbPessoaFEndereco
            // 
            this.lbPessoaFEndereco.AutoSize = true;
            this.lbPessoaFEndereco.Location = new System.Drawing.Point(28, 208);
            this.lbPessoaFEndereco.Name = "lbPessoaFEndereco";
            this.lbPessoaFEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbPessoaFEndereco.TabIndex = 18;
            this.lbPessoaFEndereco.Text = "Endereço:";
            this.lbPessoaFEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPessoaFCidade
            // 
            this.lbPessoaFCidade.AutoSize = true;
            this.lbPessoaFCidade.Location = new System.Drawing.Point(28, 234);
            this.lbPessoaFCidade.Name = "lbPessoaFCidade";
            this.lbPessoaFCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFCidade.Size = new System.Drawing.Size(43, 13);
            this.lbPessoaFCidade.TabIndex = 20;
            this.lbPessoaFCidade.Text = "Cidade:";
            this.lbPessoaFCidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFCidade
            // 
            this.txPessoaFCidade.Location = new System.Drawing.Point(141, 231);
            this.txPessoaFCidade.Name = "txPessoaFCidade";
            this.txPessoaFCidade.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFCidade.TabIndex = 19;
            // 
            // lbPessoaFBairro
            // 
            this.lbPessoaFBairro.AutoSize = true;
            this.lbPessoaFBairro.Location = new System.Drawing.Point(28, 260);
            this.lbPessoaFBairro.Name = "lbPessoaFBairro";
            this.lbPessoaFBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFBairro.Size = new System.Drawing.Size(37, 13);
            this.lbPessoaFBairro.TabIndex = 22;
            this.lbPessoaFBairro.Text = "Bairro:";
            this.lbPessoaFBairro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFBairro
            // 
            this.txPessoaFBairro.Location = new System.Drawing.Point(141, 257);
            this.txPessoaFBairro.Name = "txPessoaFBairro";
            this.txPessoaFBairro.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFBairro.TabIndex = 21;
            // 
            // lbPessoaFRua
            // 
            this.lbPessoaFRua.AutoSize = true;
            this.lbPessoaFRua.Location = new System.Drawing.Point(28, 286);
            this.lbPessoaFRua.Name = "lbPessoaFRua";
            this.lbPessoaFRua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFRua.Size = new System.Drawing.Size(30, 13);
            this.lbPessoaFRua.TabIndex = 24;
            this.lbPessoaFRua.Text = "Rua:";
            this.lbPessoaFRua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFRua
            // 
            this.txPessoaFRua.Location = new System.Drawing.Point(141, 283);
            this.txPessoaFRua.Name = "txPessoaFRua";
            this.txPessoaFRua.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFRua.TabIndex = 23;
            // 
            // lbPessoaFNumero
            // 
            this.lbPessoaFNumero.AutoSize = true;
            this.lbPessoaFNumero.Location = new System.Drawing.Point(28, 312);
            this.lbPessoaFNumero.Name = "lbPessoaFNumero";
            this.lbPessoaFNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFNumero.Size = new System.Drawing.Size(47, 13);
            this.lbPessoaFNumero.TabIndex = 26;
            this.lbPessoaFNumero.Text = "Número:";
            this.lbPessoaFNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFNumero
            // 
            this.txPessoaFNumero.Location = new System.Drawing.Point(141, 309);
            this.txPessoaFNumero.Name = "txPessoaFNumero";
            this.txPessoaFNumero.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFNumero.TabIndex = 25;
            // 
            // lbPessoaFComplemento
            // 
            this.lbPessoaFComplemento.AutoSize = true;
            this.lbPessoaFComplemento.Location = new System.Drawing.Point(28, 338);
            this.lbPessoaFComplemento.Name = "lbPessoaFComplemento";
            this.lbPessoaFComplemento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFComplemento.Size = new System.Drawing.Size(74, 13);
            this.lbPessoaFComplemento.TabIndex = 28;
            this.lbPessoaFComplemento.Text = "Complemento:";
            this.lbPessoaFComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFComplemento
            // 
            this.txPessoaFComplemento.Location = new System.Drawing.Point(141, 335);
            this.txPessoaFComplemento.Name = "txPessoaFComplemento";
            this.txPessoaFComplemento.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFComplemento.TabIndex = 27;
            // 
            // lvPessoaFLista
            // 
            this.lvPessoaFLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Data_de_Nascimento,
            this.RG,
            this.CPF,
            this.Cidade,
            this.Bairro,
            this.Rua,
            this.Número,
            this.Complemento});
            this.lvPessoaFLista.HideSelection = false;
            this.lvPessoaFLista.Location = new System.Drawing.Point(358, 80);
            this.lvPessoaFLista.Name = "lvPessoaFLista";
            this.lvPessoaFLista.Size = new System.Drawing.Size(418, 275);
            this.lvPessoaFLista.TabIndex = 29;
            this.lvPessoaFLista.UseCompatibleStateImageBehavior = false;
            //this.lvPessoaFLista.SelectedIndexChanged += new System.EventHandler(this.lvPessoaFLista_SelectedIndexChanged);
            // 
            // btPessoaFSalvar
            // 
            this.btPessoaFSalvar.Location = new System.Drawing.Point(131, 393);
            this.btPessoaFSalvar.Name = "btPessoaFSalvar";
            this.btPessoaFSalvar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaFSalvar.TabIndex = 30;
            this.btPessoaFSalvar.Text = "Salvar";
            this.btPessoaFSalvar.UseVisualStyleBackColor = true;
            this.btPessoaFSalvar.Click += new System.EventHandler(this.btPessoaFSalvar_Click);
            // 
            // btPessoaFVoltar
            // 
            this.btPessoaFVoltar.Location = new System.Drawing.Point(701, 393);
            this.btPessoaFVoltar.Name = "btPessoaFVoltar";
            this.btPessoaFVoltar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaFVoltar.TabIndex = 31;
            this.btPessoaFVoltar.Text = "Voltar";
            this.btPessoaFVoltar.UseVisualStyleBackColor = true;
            // 
            // btPessoaFLimpar
            // 
            this.btPessoaFLimpar.Location = new System.Drawing.Point(212, 393);
            this.btPessoaFLimpar.Name = "btPessoaFLimpar";
            this.btPessoaFLimpar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaFLimpar.TabIndex = 32;
            this.btPessoaFLimpar.Text = "Limpar";
            this.btPessoaFLimpar.UseVisualStyleBackColor = true;
            // 
            // dtPessoaFDataNascimento
            // 
            this.dtPessoaFDataNascimento.Location = new System.Drawing.Point(141, 106);
            this.dtPessoaFDataNascimento.Name = "dtPessoaFDataNascimento";
            this.dtPessoaFDataNascimento.Size = new System.Drawing.Size(211, 20);
            this.dtPessoaFDataNascimento.TabIndex = 33;
            // 
            // Rua
            // 
            this.Rua.DisplayIndex = 0;
            // 
            // Nome
            // 
            this.Nome.DisplayIndex = 1;
            // 
            // Data_de_Nascimento
            // 
            this.Data_de_Nascimento.DisplayIndex = 2;
            // 
            // RG
            // 
            this.RG.DisplayIndex = 3;
            // 
            // CPF
            // 
            this.CPF.DisplayIndex = 4;
            // 
            // Cidade
            // 
            this.Cidade.DisplayIndex = 5;
            // 
            // Bairro
            // 
            this.Bairro.DisplayIndex = 6;
            // 
            // OperacoesPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtPessoaFDataNascimento);
            this.Controls.Add(this.btPessoaFLimpar);
            this.Controls.Add(this.btPessoaFVoltar);
            this.Controls.Add(this.btPessoaFSalvar);
            this.Controls.Add(this.lvPessoaFLista);
            this.Controls.Add(this.lbPessoaFComplemento);
            this.Controls.Add(this.txPessoaFComplemento);
            this.Controls.Add(this.lbPessoaFNumero);
            this.Controls.Add(this.txPessoaFNumero);
            this.Controls.Add(this.lbPessoaFRua);
            this.Controls.Add(this.txPessoaFRua);
            this.Controls.Add(this.lbPessoaFBairro);
            this.Controls.Add(this.txPessoaFBairro);
            this.Controls.Add(this.lbPessoaFCidade);
            this.Controls.Add(this.txPessoaFCidade);
            this.Controls.Add(this.lbPessoaFEndereco);
            this.Controls.Add(this.lbPessoaFCpf);
            this.Controls.Add(this.txPessoaFCpf);
            this.Controls.Add(this.lbPessoaFRg);
            this.Controls.Add(this.txPessoaFRg);
            this.Controls.Add(this.lbPessoaFDataNascimento);
            this.Controls.Add(this.lbEditavel);
            this.Controls.Add(this.lbPessoaFNome);
            this.Controls.Add(this.txPessoaFNome);
            this.Name = "OperacoesPessoaFisica";
            this.Text = "OperacoesPessoaFisica";
            this.Load += new System.EventHandler(this.OperacoesPessoaFisica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txPessoaFNome;
        private System.Windows.Forms.Label lbPessoaFNome;
        private System.Windows.Forms.Label lbEditavel;
        private System.Windows.Forms.Label lbPessoaFDataNascimento;
        private System.Windows.Forms.Label lbPessoaFCpf;
        private System.Windows.Forms.TextBox txPessoaFCpf;
        private System.Windows.Forms.Label lbPessoaFRg;
        private System.Windows.Forms.TextBox txPessoaFRg;
        private System.Windows.Forms.Label lbPessoaFEndereco;
        private System.Windows.Forms.Label lbPessoaFCidade;
        private System.Windows.Forms.TextBox txPessoaFCidade;
        private System.Windows.Forms.Label lbPessoaFBairro;
        private System.Windows.Forms.TextBox txPessoaFBairro;
        private System.Windows.Forms.Label lbPessoaFRua;
        private System.Windows.Forms.TextBox txPessoaFRua;
        private System.Windows.Forms.Label lbPessoaFNumero;
        private System.Windows.Forms.TextBox txPessoaFNumero;
        private System.Windows.Forms.Label lbPessoaFComplemento;
        private System.Windows.Forms.TextBox txPessoaFComplemento;
        private System.Windows.Forms.ListView lvPessoaFLista;
        private System.Windows.Forms.Button btPessoaFSalvar;
        private System.Windows.Forms.Button btPessoaFVoltar;
        private System.Windows.Forms.Button btPessoaFLimpar;
        private System.Windows.Forms.DateTimePicker dtPessoaFDataNascimento;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Data_de_Nascimento;
        private System.Windows.Forms.ColumnHeader RG;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.ColumnHeader Rua;
        private System.Windows.Forms.ColumnHeader Número;
        private System.Windows.Forms.ColumnHeader Complemento;
    }
}