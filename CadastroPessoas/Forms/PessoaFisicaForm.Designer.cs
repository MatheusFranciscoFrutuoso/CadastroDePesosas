
namespace Forms
{
    partial class PessoaFisicaForm
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
            this.dgPessoaFLista = new System.Windows.Forms.DataGridView();
            this.dtPessoaFDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btPessoaFLimpar = new System.Windows.Forms.Button();
            this.btPessoaFVoltar = new System.Windows.Forms.Button();
            this.btPessoaFSalvar = new System.Windows.Forms.Button();
            this.lbPessoaFComplemento = new System.Windows.Forms.Label();
            this.txPessoaFComplemento = new System.Windows.Forms.TextBox();
            this.lbPessoaFNumero = new System.Windows.Forms.Label();
            this.txPessoaFNumero = new System.Windows.Forms.TextBox();
            this.lbPessoaFRua = new System.Windows.Forms.Label();
            this.txPessoaFRua = new System.Windows.Forms.TextBox();
            this.lbPessoaFBairro = new System.Windows.Forms.Label();
            this.txPessoaFBairro = new System.Windows.Forms.TextBox();
            this.lbPessoaFCidade = new System.Windows.Forms.Label();
            this.txPessoaFCidade = new System.Windows.Forms.TextBox();
            this.lbPessoaFEndereco = new System.Windows.Forms.Label();
            this.lbPessoaFCpf = new System.Windows.Forms.Label();
            this.txPessoaFCpf = new System.Windows.Forms.TextBox();
            this.lbPessoaFRg = new System.Windows.Forms.Label();
            this.txPessoaFRg = new System.Windows.Forms.TextBox();
            this.lbPessoaFDataNascimento = new System.Windows.Forms.Label();
            this.lbEditavel = new System.Windows.Forms.Label();
            this.lbPessoaFNome = new System.Windows.Forms.Label();
            this.txPessoaFNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoaFLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPessoaFLista
            // 
            this.dgPessoaFLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPessoaFLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.DataNascimento,
            this.RG,
            this.CPF,
            this.Cidade,
            this.Bairro,
            this.Rua,
            this.Número,
            this.Complemento});
            this.dgPessoaFLista.Location = new System.Drawing.Point(356, 82);
            this.dgPessoaFLista.Name = "dgPessoaFLista";
            this.dgPessoaFLista.Size = new System.Drawing.Size(418, 275);
            this.dgPessoaFLista.TabIndex = 58;
            this.dgPessoaFLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPessoaFLista_CellContentClick);
            // 
            // dtPessoaFDataNascimento
            // 
            this.dtPessoaFDataNascimento.Location = new System.Drawing.Point(139, 108);
            this.dtPessoaFDataNascimento.Name = "dtPessoaFDataNascimento";
            this.dtPessoaFDataNascimento.Size = new System.Drawing.Size(211, 20);
            this.dtPessoaFDataNascimento.TabIndex = 57;
            // 
            // btPessoaFLimpar
            // 
            this.btPessoaFLimpar.Location = new System.Drawing.Point(210, 395);
            this.btPessoaFLimpar.Name = "btPessoaFLimpar";
            this.btPessoaFLimpar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaFLimpar.TabIndex = 56;
            this.btPessoaFLimpar.Text = "Limpar";
            this.btPessoaFLimpar.UseVisualStyleBackColor = true;
            this.btPessoaFLimpar.Click += new System.EventHandler(this.btPessoaFLimpar_Click);
            // 
            // btPessoaFVoltar
            // 
            this.btPessoaFVoltar.Location = new System.Drawing.Point(699, 395);
            this.btPessoaFVoltar.Name = "btPessoaFVoltar";
            this.btPessoaFVoltar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaFVoltar.TabIndex = 55;
            this.btPessoaFVoltar.Text = "Voltar";
            this.btPessoaFVoltar.UseVisualStyleBackColor = true;
            // 
            // btPessoaFSalvar
            // 
            this.btPessoaFSalvar.Location = new System.Drawing.Point(129, 395);
            this.btPessoaFSalvar.Name = "btPessoaFSalvar";
            this.btPessoaFSalvar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaFSalvar.TabIndex = 54;
            this.btPessoaFSalvar.Text = "Salvar";
            this.btPessoaFSalvar.UseVisualStyleBackColor = true;
            this.btPessoaFSalvar.Click += new System.EventHandler(this.btPessoaFSalvar_Click);
            // 
            // lbPessoaFComplemento
            // 
            this.lbPessoaFComplemento.AutoSize = true;
            this.lbPessoaFComplemento.Location = new System.Drawing.Point(26, 340);
            this.lbPessoaFComplemento.Name = "lbPessoaFComplemento";
            this.lbPessoaFComplemento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFComplemento.Size = new System.Drawing.Size(74, 13);
            this.lbPessoaFComplemento.TabIndex = 53;
            this.lbPessoaFComplemento.Text = "Complemento:";
            this.lbPessoaFComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFComplemento
            // 
            this.txPessoaFComplemento.Location = new System.Drawing.Point(139, 337);
            this.txPessoaFComplemento.Name = "txPessoaFComplemento";
            this.txPessoaFComplemento.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFComplemento.TabIndex = 52;
            // 
            // lbPessoaFNumero
            // 
            this.lbPessoaFNumero.AutoSize = true;
            this.lbPessoaFNumero.Location = new System.Drawing.Point(26, 314);
            this.lbPessoaFNumero.Name = "lbPessoaFNumero";
            this.lbPessoaFNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFNumero.Size = new System.Drawing.Size(47, 13);
            this.lbPessoaFNumero.TabIndex = 51;
            this.lbPessoaFNumero.Text = "Número:";
            this.lbPessoaFNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFNumero
            // 
            this.txPessoaFNumero.Location = new System.Drawing.Point(139, 311);
            this.txPessoaFNumero.Name = "txPessoaFNumero";
            this.txPessoaFNumero.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFNumero.TabIndex = 50;
            // 
            // lbPessoaFRua
            // 
            this.lbPessoaFRua.AutoSize = true;
            this.lbPessoaFRua.Location = new System.Drawing.Point(26, 288);
            this.lbPessoaFRua.Name = "lbPessoaFRua";
            this.lbPessoaFRua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFRua.Size = new System.Drawing.Size(30, 13);
            this.lbPessoaFRua.TabIndex = 49;
            this.lbPessoaFRua.Text = "Rua:";
            this.lbPessoaFRua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFRua
            // 
            this.txPessoaFRua.Location = new System.Drawing.Point(139, 285);
            this.txPessoaFRua.Name = "txPessoaFRua";
            this.txPessoaFRua.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFRua.TabIndex = 48;
            // 
            // lbPessoaFBairro
            // 
            this.lbPessoaFBairro.AutoSize = true;
            this.lbPessoaFBairro.Location = new System.Drawing.Point(26, 262);
            this.lbPessoaFBairro.Name = "lbPessoaFBairro";
            this.lbPessoaFBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFBairro.Size = new System.Drawing.Size(37, 13);
            this.lbPessoaFBairro.TabIndex = 47;
            this.lbPessoaFBairro.Text = "Bairro:";
            this.lbPessoaFBairro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFBairro
            // 
            this.txPessoaFBairro.Location = new System.Drawing.Point(139, 259);
            this.txPessoaFBairro.Name = "txPessoaFBairro";
            this.txPessoaFBairro.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFBairro.TabIndex = 46;
            // 
            // lbPessoaFCidade
            // 
            this.lbPessoaFCidade.AutoSize = true;
            this.lbPessoaFCidade.Location = new System.Drawing.Point(26, 236);
            this.lbPessoaFCidade.Name = "lbPessoaFCidade";
            this.lbPessoaFCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFCidade.Size = new System.Drawing.Size(43, 13);
            this.lbPessoaFCidade.TabIndex = 45;
            this.lbPessoaFCidade.Text = "Cidade:";
            this.lbPessoaFCidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFCidade
            // 
            this.txPessoaFCidade.Location = new System.Drawing.Point(139, 233);
            this.txPessoaFCidade.Name = "txPessoaFCidade";
            this.txPessoaFCidade.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFCidade.TabIndex = 44;
            // 
            // lbPessoaFEndereco
            // 
            this.lbPessoaFEndereco.AutoSize = true;
            this.lbPessoaFEndereco.Location = new System.Drawing.Point(26, 210);
            this.lbPessoaFEndereco.Name = "lbPessoaFEndereco";
            this.lbPessoaFEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbPessoaFEndereco.TabIndex = 43;
            this.lbPessoaFEndereco.Text = "Endereço:";
            this.lbPessoaFEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPessoaFCpf
            // 
            this.lbPessoaFCpf.AutoSize = true;
            this.lbPessoaFCpf.Location = new System.Drawing.Point(26, 163);
            this.lbPessoaFCpf.Name = "lbPessoaFCpf";
            this.lbPessoaFCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFCpf.Size = new System.Drawing.Size(30, 13);
            this.lbPessoaFCpf.TabIndex = 42;
            this.lbPessoaFCpf.Text = "CPF:";
            this.lbPessoaFCpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFCpf
            // 
            this.txPessoaFCpf.Location = new System.Drawing.Point(139, 160);
            this.txPessoaFCpf.Name = "txPessoaFCpf";
            this.txPessoaFCpf.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFCpf.TabIndex = 41;
            // 
            // lbPessoaFRg
            // 
            this.lbPessoaFRg.AutoSize = true;
            this.lbPessoaFRg.Location = new System.Drawing.Point(26, 137);
            this.lbPessoaFRg.Name = "lbPessoaFRg";
            this.lbPessoaFRg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFRg.Size = new System.Drawing.Size(26, 13);
            this.lbPessoaFRg.TabIndex = 40;
            this.lbPessoaFRg.Text = "RG:";
            this.lbPessoaFRg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFRg
            // 
            this.txPessoaFRg.Location = new System.Drawing.Point(139, 134);
            this.txPessoaFRg.Name = "txPessoaFRg";
            this.txPessoaFRg.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFRg.TabIndex = 39;
            // 
            // lbPessoaFDataNascimento
            // 
            this.lbPessoaFDataNascimento.AutoSize = true;
            this.lbPessoaFDataNascimento.Location = new System.Drawing.Point(26, 111);
            this.lbPessoaFDataNascimento.Name = "lbPessoaFDataNascimento";
            this.lbPessoaFDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbPessoaFDataNascimento.TabIndex = 38;
            this.lbPessoaFDataNascimento.Text = "Data de Nascimento:";
            this.lbPessoaFDataNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEditavel
            // 
            this.lbEditavel.AutoSize = true;
            this.lbEditavel.BackColor = System.Drawing.Color.Transparent;
            this.lbEditavel.ForeColor = System.Drawing.Color.Black;
            this.lbEditavel.Location = new System.Drawing.Point(353, 32);
            this.lbEditavel.Name = "lbEditavel";
            this.lbEditavel.Size = new System.Drawing.Size(74, 13);
            this.lbEditavel.TabIndex = 37;
            this.lbEditavel.Text = "Pessoa Física";
            this.lbEditavel.Click += new System.EventHandler(this.lbEditavel_Click);
            // 
            // lbPessoaFNome
            // 
            this.lbPessoaFNome.AutoSize = true;
            this.lbPessoaFNome.Location = new System.Drawing.Point(26, 85);
            this.lbPessoaFNome.Name = "lbPessoaFNome";
            this.lbPessoaFNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaFNome.Size = new System.Drawing.Size(38, 13);
            this.lbPessoaFNome.TabIndex = 36;
            this.lbPessoaFNome.Text = "Nome:";
            this.lbPessoaFNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaFNome
            // 
            this.txPessoaFNome.Location = new System.Drawing.Point(139, 82);
            this.txPessoaFNome.Name = "txPessoaFNome";
            this.txPessoaFNome.Size = new System.Drawing.Size(211, 20);
            this.txPessoaFNome.TabIndex = 35;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // Rua
            // 
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            // 
            // Complemento
            // 
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            // 
            // PessoaFisicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPessoaFLista);
            this.Controls.Add(this.dtPessoaFDataNascimento);
            this.Controls.Add(this.btPessoaFLimpar);
            this.Controls.Add(this.btPessoaFVoltar);
            this.Controls.Add(this.btPessoaFSalvar);
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
            this.Name = "PessoaFisicaForm";
            this.Text = "PessoaFisicaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoaFLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPessoaFLista;
        private System.Windows.Forms.DateTimePicker dtPessoaFDataNascimento;
        private System.Windows.Forms.Button btPessoaFLimpar;
        private System.Windows.Forms.Button btPessoaFVoltar;
        private System.Windows.Forms.Button btPessoaFSalvar;
        private System.Windows.Forms.Label lbPessoaFComplemento;
        private System.Windows.Forms.TextBox txPessoaFComplemento;
        private System.Windows.Forms.Label lbPessoaFNumero;
        private System.Windows.Forms.TextBox txPessoaFNumero;
        private System.Windows.Forms.Label lbPessoaFRua;
        private System.Windows.Forms.TextBox txPessoaFRua;
        private System.Windows.Forms.Label lbPessoaFBairro;
        private System.Windows.Forms.TextBox txPessoaFBairro;
        private System.Windows.Forms.Label lbPessoaFCidade;
        private System.Windows.Forms.TextBox txPessoaFCidade;
        private System.Windows.Forms.Label lbPessoaFEndereco;
        private System.Windows.Forms.Label lbPessoaFCpf;
        private System.Windows.Forms.TextBox txPessoaFCpf;
        private System.Windows.Forms.Label lbPessoaFRg;
        private System.Windows.Forms.TextBox txPessoaFRg;
        private System.Windows.Forms.Label lbPessoaFDataNascimento;
        private System.Windows.Forms.Label lbEditavel;
        private System.Windows.Forms.Label lbPessoaFNome;
        private System.Windows.Forms.TextBox txPessoaFNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
    }
}