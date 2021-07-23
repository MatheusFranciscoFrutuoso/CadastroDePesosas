
namespace Forms
{
    partial class PessoaJuridicaForm
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
            this.dtPessoaJDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btPessoaJLimpar = new System.Windows.Forms.Button();
            this.btPessoaJVoltar = new System.Windows.Forms.Button();
            this.btPessoaJSalvar = new System.Windows.Forms.Button();
            this.lbPessoaJComplemento = new System.Windows.Forms.Label();
            this.txPessoaJComplemento = new System.Windows.Forms.TextBox();
            this.lbPessoaJNumero = new System.Windows.Forms.Label();
            this.txPessoaJNumero = new System.Windows.Forms.TextBox();
            this.lbPessoaJRua = new System.Windows.Forms.Label();
            this.txPessoaJRua = new System.Windows.Forms.TextBox();
            this.lbPessoaJBairro = new System.Windows.Forms.Label();
            this.txPessoaJBairro = new System.Windows.Forms.TextBox();
            this.lbPessoaJCidade = new System.Windows.Forms.Label();
            this.txPessoaJCidade = new System.Windows.Forms.TextBox();
            this.lbPessoaJEndereco = new System.Windows.Forms.Label();
            this.lbPessoaJCnpj = new System.Windows.Forms.Label();
            this.txPessoaJCnpj = new System.Windows.Forms.TextBox();
            this.lbPessoaJIe = new System.Windows.Forms.Label();
            this.txPessoaJIe = new System.Windows.Forms.TextBox();
            this.lbPessoaJDataNascimento = new System.Windows.Forms.Label();
            this.lbPessoaJIntro = new System.Windows.Forms.Label();
            this.lbPessoaJNome = new System.Windows.Forms.Label();
            this.txPessoaJNome = new System.Windows.Forms.TextBox();
            this.dgPessoaJLista = new System.Windows.Forms.DataGridView();
            this.btPessoaJEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btPessoaJDeletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoaJLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPessoaJDataNascimento
            // 
            this.dtPessoaJDataNascimento.Location = new System.Drawing.Point(139, 108);
            this.dtPessoaJDataNascimento.Name = "dtPessoaJDataNascimento";
            this.dtPessoaJDataNascimento.Size = new System.Drawing.Size(211, 20);
            this.dtPessoaJDataNascimento.TabIndex = 81;
            // 
            // btPessoaJLimpar
            // 
            this.btPessoaJLimpar.Location = new System.Drawing.Point(220, 395);
            this.btPessoaJLimpar.Name = "btPessoaJLimpar";
            this.btPessoaJLimpar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaJLimpar.TabIndex = 80;
            this.btPessoaJLimpar.Text = "Limpar";
            this.btPessoaJLimpar.UseVisualStyleBackColor = true;
            this.btPessoaJLimpar.Click += new System.EventHandler(this.btPessoaJLimpar_Click);
            // 
            // btPessoaJVoltar
            // 
            this.btPessoaJVoltar.Location = new System.Drawing.Point(699, 395);
            this.btPessoaJVoltar.Name = "btPessoaJVoltar";
            this.btPessoaJVoltar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaJVoltar.TabIndex = 79;
            this.btPessoaJVoltar.Text = "Voltar";
            this.btPessoaJVoltar.UseVisualStyleBackColor = true;
            // 
            // btPessoaJSalvar
            // 
            this.btPessoaJSalvar.Location = new System.Drawing.Point(139, 395);
            this.btPessoaJSalvar.Name = "btPessoaJSalvar";
            this.btPessoaJSalvar.Size = new System.Drawing.Size(75, 23);
            this.btPessoaJSalvar.TabIndex = 78;
            this.btPessoaJSalvar.Text = "Salvar";
            this.btPessoaJSalvar.UseVisualStyleBackColor = true;
            this.btPessoaJSalvar.Click += new System.EventHandler(this.btPessoaJSalvar_Click);
            // 
            // lbPessoaJComplemento
            // 
            this.lbPessoaJComplemento.AutoSize = true;
            this.lbPessoaJComplemento.Location = new System.Drawing.Point(26, 340);
            this.lbPessoaJComplemento.Name = "lbPessoaJComplemento";
            this.lbPessoaJComplemento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJComplemento.Size = new System.Drawing.Size(74, 13);
            this.lbPessoaJComplemento.TabIndex = 76;
            this.lbPessoaJComplemento.Text = "Complemento:";
            this.lbPessoaJComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaJComplemento
            // 
            this.txPessoaJComplemento.Location = new System.Drawing.Point(139, 337);
            this.txPessoaJComplemento.Name = "txPessoaJComplemento";
            this.txPessoaJComplemento.Size = new System.Drawing.Size(211, 20);
            this.txPessoaJComplemento.TabIndex = 75;
            // 
            // lbPessoaJNumero
            // 
            this.lbPessoaJNumero.AutoSize = true;
            this.lbPessoaJNumero.Location = new System.Drawing.Point(26, 314);
            this.lbPessoaJNumero.Name = "lbPessoaJNumero";
            this.lbPessoaJNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJNumero.Size = new System.Drawing.Size(47, 13);
            this.lbPessoaJNumero.TabIndex = 74;
            this.lbPessoaJNumero.Text = "Número:";
            this.lbPessoaJNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaJNumero
            // 
            this.txPessoaJNumero.Location = new System.Drawing.Point(139, 311);
            this.txPessoaJNumero.Name = "txPessoaJNumero";
            this.txPessoaJNumero.Size = new System.Drawing.Size(211, 20);
            this.txPessoaJNumero.TabIndex = 73;
            // 
            // lbPessoaJRua
            // 
            this.lbPessoaJRua.AutoSize = true;
            this.lbPessoaJRua.Location = new System.Drawing.Point(26, 288);
            this.lbPessoaJRua.Name = "lbPessoaJRua";
            this.lbPessoaJRua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJRua.Size = new System.Drawing.Size(30, 13);
            this.lbPessoaJRua.TabIndex = 72;
            this.lbPessoaJRua.Text = "Rua:";
            this.lbPessoaJRua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaJRua
            // 
            this.txPessoaJRua.Location = new System.Drawing.Point(139, 285);
            this.txPessoaJRua.Name = "txPessoaJRua";
            this.txPessoaJRua.Size = new System.Drawing.Size(211, 20);
            this.txPessoaJRua.TabIndex = 71;
            // 
            // lbPessoaJBairro
            // 
            this.lbPessoaJBairro.AutoSize = true;
            this.lbPessoaJBairro.Location = new System.Drawing.Point(26, 262);
            this.lbPessoaJBairro.Name = "lbPessoaJBairro";
            this.lbPessoaJBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJBairro.Size = new System.Drawing.Size(37, 13);
            this.lbPessoaJBairro.TabIndex = 70;
            this.lbPessoaJBairro.Text = "Bairro:";
            this.lbPessoaJBairro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaJBairro
            // 
            this.txPessoaJBairro.Location = new System.Drawing.Point(139, 259);
            this.txPessoaJBairro.Name = "txPessoaJBairro";
            this.txPessoaJBairro.Size = new System.Drawing.Size(211, 20);
            this.txPessoaJBairro.TabIndex = 69;
            // 
            // lbPessoaJCidade
            // 
            this.lbPessoaJCidade.AutoSize = true;
            this.lbPessoaJCidade.Location = new System.Drawing.Point(26, 236);
            this.lbPessoaJCidade.Name = "lbPessoaJCidade";
            this.lbPessoaJCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJCidade.Size = new System.Drawing.Size(43, 13);
            this.lbPessoaJCidade.TabIndex = 68;
            this.lbPessoaJCidade.Text = "Cidade:";
            this.lbPessoaJCidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaJCidade
            // 
            this.txPessoaJCidade.Location = new System.Drawing.Point(139, 233);
            this.txPessoaJCidade.Name = "txPessoaJCidade";
            this.txPessoaJCidade.Size = new System.Drawing.Size(211, 20);
            this.txPessoaJCidade.TabIndex = 67;
            // 
            // lbPessoaJEndereco
            // 
            this.lbPessoaJEndereco.AutoSize = true;
            this.lbPessoaJEndereco.Location = new System.Drawing.Point(26, 210);
            this.lbPessoaJEndereco.Name = "lbPessoaJEndereco";
            this.lbPessoaJEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbPessoaJEndereco.TabIndex = 66;
            this.lbPessoaJEndereco.Text = "Endereço:";
            this.lbPessoaJEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPessoaJCnpj
            // 
            this.lbPessoaJCnpj.AutoSize = true;
            this.lbPessoaJCnpj.Location = new System.Drawing.Point(26, 163);
            this.lbPessoaJCnpj.Name = "lbPessoaJCnpj";
            this.lbPessoaJCnpj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJCnpj.Size = new System.Drawing.Size(37, 13);
            this.lbPessoaJCnpj.TabIndex = 65;
            this.lbPessoaJCnpj.Text = "CNPJ:";
            this.lbPessoaJCnpj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaJCnpj
            // 
            this.txPessoaJCnpj.Location = new System.Drawing.Point(139, 160);
            this.txPessoaJCnpj.Name = "txPessoaJCnpj";
            this.txPessoaJCnpj.Size = new System.Drawing.Size(211, 20);
            this.txPessoaJCnpj.TabIndex = 64;
            // 
            // lbPessoaJIe
            // 
            this.lbPessoaJIe.AutoSize = true;
            this.lbPessoaJIe.Location = new System.Drawing.Point(26, 137);
            this.lbPessoaJIe.Name = "lbPessoaJIe";
            this.lbPessoaJIe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJIe.Size = new System.Drawing.Size(20, 13);
            this.lbPessoaJIe.TabIndex = 63;
            this.lbPessoaJIe.Text = "IE:";
            this.lbPessoaJIe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaJIe
            // 
            this.txPessoaJIe.Location = new System.Drawing.Point(139, 134);
            this.txPessoaJIe.Name = "txPessoaJIe";
            this.txPessoaJIe.Size = new System.Drawing.Size(211, 20);
            this.txPessoaJIe.TabIndex = 62;
            // 
            // lbPessoaJDataNascimento
            // 
            this.lbPessoaJDataNascimento.AutoSize = true;
            this.lbPessoaJDataNascimento.Location = new System.Drawing.Point(26, 111);
            this.lbPessoaJDataNascimento.Name = "lbPessoaJDataNascimento";
            this.lbPessoaJDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbPessoaJDataNascimento.TabIndex = 61;
            this.lbPessoaJDataNascimento.Text = "Data de Nascimento:";
            this.lbPessoaJDataNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPessoaJIntro
            // 
            this.lbPessoaJIntro.AutoSize = true;
            this.lbPessoaJIntro.BackColor = System.Drawing.Color.Transparent;
            this.lbPessoaJIntro.ForeColor = System.Drawing.Color.Black;
            this.lbPessoaJIntro.Location = new System.Drawing.Point(353, 32);
            this.lbPessoaJIntro.Name = "lbPessoaJIntro";
            this.lbPessoaJIntro.Size = new System.Drawing.Size(83, 13);
            this.lbPessoaJIntro.TabIndex = 60;
            this.lbPessoaJIntro.Text = "Pessoa Jurídica";
            // 
            // lbPessoaJNome
            // 
            this.lbPessoaJNome.AutoSize = true;
            this.lbPessoaJNome.Location = new System.Drawing.Point(26, 85);
            this.lbPessoaJNome.Name = "lbPessoaJNome";
            this.lbPessoaJNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPessoaJNome.Size = new System.Drawing.Size(38, 13);
            this.lbPessoaJNome.TabIndex = 59;
            this.lbPessoaJNome.Text = "Nome:";
            this.lbPessoaJNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPessoaJNome
            // 
            this.txPessoaJNome.Location = new System.Drawing.Point(139, 82);
            this.txPessoaJNome.Name = "txPessoaJNome";
            this.txPessoaJNome.Size = new System.Drawing.Size(211, 20);
            this.txPessoaJNome.TabIndex = 58;
            // 
            // dgPessoaJLista
            // 
            this.dgPessoaJLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPessoaJLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btPessoaJEditar,
            this.btPessoaJDeletar,
            this.Nome,
            this.DataNascimento,
            this.IE,
            this.CNPJ,
            this.Cidade,
            this.Bairro,
            this.Rua,
            this.Número,
            this.Complemento});
            this.dgPessoaJLista.Location = new System.Drawing.Point(356, 82);
            this.dgPessoaJLista.Name = "dgPessoaJLista";
            this.dgPessoaJLista.Size = new System.Drawing.Size(418, 275);
            this.dgPessoaJLista.TabIndex = 82;
            this.dgPessoaJLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPessoaJLista_CellContentClick);
            // 
            // btPessoaJEditar
            // 
            this.btPessoaJEditar.HeaderText = "";
            this.btPessoaJEditar.Name = "btPessoaJEditar";
            this.btPessoaJEditar.Width = 45;
            // 
            // btPessoaJDeletar
            // 
            this.btPessoaJDeletar.HeaderText = "";
            this.btPessoaJDeletar.Name = "btPessoaJDeletar";
            this.btPessoaJDeletar.Width = 45;
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
            // IE
            // 
            this.IE.HeaderText = "IE";
            this.IE.Name = "IE";
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
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
            // PessoaJuridicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPessoaJLista);
            this.Controls.Add(this.dtPessoaJDataNascimento);
            this.Controls.Add(this.btPessoaJLimpar);
            this.Controls.Add(this.btPessoaJVoltar);
            this.Controls.Add(this.btPessoaJSalvar);
            this.Controls.Add(this.lbPessoaJComplemento);
            this.Controls.Add(this.txPessoaJComplemento);
            this.Controls.Add(this.lbPessoaJNumero);
            this.Controls.Add(this.txPessoaJNumero);
            this.Controls.Add(this.lbPessoaJRua);
            this.Controls.Add(this.txPessoaJRua);
            this.Controls.Add(this.lbPessoaJBairro);
            this.Controls.Add(this.txPessoaJBairro);
            this.Controls.Add(this.lbPessoaJCidade);
            this.Controls.Add(this.txPessoaJCidade);
            this.Controls.Add(this.lbPessoaJEndereco);
            this.Controls.Add(this.lbPessoaJCnpj);
            this.Controls.Add(this.txPessoaJCnpj);
            this.Controls.Add(this.lbPessoaJIe);
            this.Controls.Add(this.txPessoaJIe);
            this.Controls.Add(this.lbPessoaJDataNascimento);
            this.Controls.Add(this.lbPessoaJIntro);
            this.Controls.Add(this.lbPessoaJNome);
            this.Controls.Add(this.txPessoaJNome);
            this.Name = "PessoaJuridicaForm";
            this.Text = "PessoaJuridicaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoaJLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPessoaJDataNascimento;
        private System.Windows.Forms.Button btPessoaJLimpar;
        private System.Windows.Forms.Button btPessoaJVoltar;
        private System.Windows.Forms.Button btPessoaJSalvar;
        private System.Windows.Forms.Label lbPessoaJComplemento;
        private System.Windows.Forms.TextBox txPessoaJComplemento;
        private System.Windows.Forms.Label lbPessoaJNumero;
        private System.Windows.Forms.TextBox txPessoaJNumero;
        private System.Windows.Forms.Label lbPessoaJRua;
        private System.Windows.Forms.TextBox txPessoaJRua;
        private System.Windows.Forms.Label lbPessoaJBairro;
        private System.Windows.Forms.TextBox txPessoaJBairro;
        private System.Windows.Forms.Label lbPessoaJCidade;
        private System.Windows.Forms.TextBox txPessoaJCidade;
        private System.Windows.Forms.Label lbPessoaJEndereco;
        private System.Windows.Forms.Label lbPessoaJCnpj;
        private System.Windows.Forms.TextBox txPessoaJCnpj;
        private System.Windows.Forms.Label lbPessoaJIe;
        private System.Windows.Forms.TextBox txPessoaJIe;
        private System.Windows.Forms.Label lbPessoaJDataNascimento;
        private System.Windows.Forms.Label lbPessoaJIntro;
        private System.Windows.Forms.Label lbPessoaJNome;
        private System.Windows.Forms.TextBox txPessoaJNome;
        private System.Windows.Forms.DataGridView dgPessoaJLista;
        private System.Windows.Forms.DataGridViewButtonColumn btPessoaJEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btPessoaJDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
    }
}