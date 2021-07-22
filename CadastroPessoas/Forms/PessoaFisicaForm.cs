using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class PessoaFisicaForm : Form
    {
        public List<Form1> PessoaFisica { get; set; }
        public PessoaFisicaForm()
        {
            InitializeComponent();
            PessoaFisica = new List<Form1>();

        }

        private void btPessoaFSalvar_Click(object sender, EventArgs e)
        {
            Form1 pessoaF = new Form1();
            string Nome = txPessoaFNome.Text;
            DateTime DataNascimento = Convert.ToDateTime(dtPessoaFDataNascimento.Text);
            pessoaF.RG = txPessoaFRg.Text;
            string CPF = txPessoaFCpf.Text;
            string Cidade = txPessoaFCidade.Text;
            string Bairro = txPessoaFBairro.Text;
            string Rua = txPessoaFRua.Text;
            int Numero = Convert.ToInt32(txPessoaFNumero.Text);
            string Complemento = txPessoaFComplemento.Text;
            this.PessoaFisica.Add(pessoaF);
        }

        private void lbEditavel_Click(object sender, EventArgs e)
        {

        }
    }
}