
namespace Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbEscolha = new System.Windows.Forms.Label();
            this.btPessoaF = new System.Windows.Forms.Button();
            this.btPessoaJ = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEscolha
            // 
            this.lbEscolha.AutoSize = true;
            this.lbEscolha.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEscolha.Location = new System.Drawing.Point(330, 200);
            this.lbEscolha.Name = "lbEscolha";
            this.lbEscolha.Size = new System.Drawing.Size(139, 22);
            this.lbEscolha.TabIndex = 0;
            this.lbEscolha.Text = "Escolha a opção:";
            // 
            // btPessoaF
            // 
            this.btPessoaF.Location = new System.Drawing.Point(334, 250);
            this.btPessoaF.Name = "btPessoaF";
            this.btPessoaF.Size = new System.Drawing.Size(135, 23);
            this.btPessoaF.TabIndex = 1;
            this.btPessoaF.Text = "Pessoa Física";
            this.btPessoaF.UseVisualStyleBackColor = true;
            this.btPessoaF.Click += new System.EventHandler(this.btPessoaF_Click);
            // 
            // btPessoaJ
            // 
            this.btPessoaJ.Location = new System.Drawing.Point(334, 279);
            this.btPessoaJ.Name = "btPessoaJ";
            this.btPessoaJ.Size = new System.Drawing.Size(135, 23);
            this.btPessoaJ.TabIndex = 2;
            this.btPessoaJ.Text = "Pessoa Jurídica";
            this.btPessoaJ.UseVisualStyleBackColor = true;
            this.btPessoaJ.Click += new System.EventHandler(this.btPessoaJ_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(334, 308);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(135, 23);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btPessoaJ);
            this.Controls.Add(this.btPessoaF);
            this.Controls.Add(this.lbEscolha);
            this.Name = "Form1";
            this.Text = "Companhia Industrial Schlosser S.A.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEscolha;
        private System.Windows.Forms.Button btPessoaF;
        private System.Windows.Forms.Button btPessoaJ;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

