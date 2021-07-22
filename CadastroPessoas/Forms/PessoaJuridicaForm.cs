using CadastroPessoas.Modelos;
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
    public partial class PessoaJuridicaForm : Form
    {
        public List<PessoaJuridica> PessoaJuridica { get; set; }
        public PessoaJuridicaForm()
        {
            InitializeComponent();
            PessoaJuridica = new List<PessoaJuridica>();
        }

        private void btPessoaJSalvar_Click(object sender, EventArgs e)
        {
            PessoaJuridica pessoaJ = new PessoaJuridica();
            string Nome = txPessoaJNome.Text;
            DateTime DataNascimento = Convert.ToDateTime(dtPessoaJDataNascimento.Text);
            string IE = txPessoaJIe.Text;
            string CNPJ = txPessoaJCnpj.Text;
            string Cidade = txPessoaJCidade.Text;
            string Bairro = txPessoaJBairro.Text;
            string Rua = txPessoaJRua.Text;
            int Numero = Convert.ToInt32(txPessoaJNumero.Text);
            string Complemento = txPessoaJComplemento.Text;
            this.PessoaJuridica.Add(pessoaJ);
        }
        /*private void CarregaFormulario(Form1 pessoaJ)
        {
            this.tbId.Text = pessoaJ.Id.ToString();
            this.txPessoaJNome.Text = pessoaJ.Nome;
            this.tbDescricao.Text = pessoaJ.Descricao;
            this.lbMensagem.Text = String.Empty;
        }*/
    }
}