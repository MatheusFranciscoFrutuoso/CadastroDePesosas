
namespace Forms
{
    partial class PessoaFisica
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
            this.btPessoaFSair = new System.Windows.Forms.Button();
            this.btPessoaFListar = new System.Windows.Forms.Button();
            this.btPessoaFCadastrar = new System.Windows.Forms.Button();
            this.lbEscolha = new System.Windows.Forms.Label();
            this.btPessoaFDeletar = new System.Windows.Forms.Button();
            this.btPessoaFEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPessoaFSair
            // 
            this.btPessoaFSair.Location = new System.Drawing.Point(335, 326);
            this.btPessoaFSair.Name = "btPessoaFSair";
            this.btPessoaFSair.Size = new System.Drawing.Size(135, 23);
            this.btPessoaFSair.TabIndex = 7;
            this.btPessoaFSair.Text = "Sair";
            this.btPessoaFSair.UseVisualStyleBackColor = true;
            // 
            // btPessoaFListar
            // 
            this.btPessoaFListar.Location = new System.Drawing.Point(335, 239);
            this.btPessoaFListar.Name = "btPessoaFListar";
            this.btPessoaFListar.Size = new System.Drawing.Size(135, 23);
            this.btPessoaFListar.TabIndex = 6;
            this.btPessoaFListar.Text = "Listar";
            this.btPessoaFListar.UseVisualStyleBackColor = true;
            // 
            // btPessoaFCadastrar
            // 
            this.btPessoaFCadastrar.Location = new System.Drawing.Point(335, 210);
            this.btPessoaFCadastrar.Name = "btPessoaFCadastrar";
            this.btPessoaFCadastrar.Size = new System.Drawing.Size(135, 23);
            this.btPessoaFCadastrar.TabIndex = 5;
            this.btPessoaFCadastrar.Text = "Cadastrar";
            this.btPessoaFCadastrar.UseVisualStyleBackColor = true;
            // 
            // lbEscolha
            // 
            this.lbEscolha.AutoSize = true;
            this.lbEscolha.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEscolha.Location = new System.Drawing.Point(331, 160);
            this.lbEscolha.Name = "lbEscolha";
            this.lbEscolha.Size = new System.Drawing.Size(139, 22);
            this.lbEscolha.TabIndex = 4;
            this.lbEscolha.Text = "Escolha a opção:";
            // 
            // btPessoaFDeletar
            // 
            this.btPessoaFDeletar.Location = new System.Drawing.Point(335, 297);
            this.btPessoaFDeletar.Name = "btPessoaFDeletar";
            this.btPessoaFDeletar.Size = new System.Drawing.Size(135, 23);
            this.btPessoaFDeletar.TabIndex = 8;
            this.btPessoaFDeletar.Text = "Deletar";
            this.btPessoaFDeletar.UseVisualStyleBackColor = true;
            // 
            // btPessoaFEditar
            // 
            this.btPessoaFEditar.Location = new System.Drawing.Point(335, 268);
            this.btPessoaFEditar.Name = "btPessoaFEditar";
            this.btPessoaFEditar.Size = new System.Drawing.Size(135, 23);
            this.btPessoaFEditar.TabIndex = 9;
            this.btPessoaFEditar.Text = "Editar";
            this.btPessoaFEditar.UseVisualStyleBackColor = true;
            // 
            // PessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPessoaFEditar);
            this.Controls.Add(this.btPessoaFDeletar);
            this.Controls.Add(this.btPessoaFSair);
            this.Controls.Add(this.btPessoaFListar);
            this.Controls.Add(this.btPessoaFCadastrar);
            this.Controls.Add(this.lbEscolha);
            this.Name = "PessoaFisica";
            this.Text = "Gestão de Pessoa Física";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPessoaFSair;
        private System.Windows.Forms.Button btPessoaFListar;
        private System.Windows.Forms.Button btPessoaFCadastrar;
        private System.Windows.Forms.Label lbEscolha;
        private System.Windows.Forms.Button btPessoaFDeletar;
        private System.Windows.Forms.Button btPessoaFEditar;
    }
}