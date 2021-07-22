using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroPessoas.Modelos;

namespace Forms
{
    public partial class PessoaFisicaForm : Form
    {
        public List<PessoaFisica> PessoaFisica { get; set; }
        public PessoaFisicaForm()
        {
            InitializeComponent();
            PessoaFisica = new List<PessoaFisica>();
            dgPessoaFLista.AutoGenerateColumns = false;
            dgPessoaFLista.AllowUserToAddRows = false;
            //CarregarLista();

        }

        private void btPessoaFSalvar_Click(object sender, EventArgs e)
        {
            PessoaFisica pessoaF = new PessoaFisica();
            pessoaF.Nome = txPessoaFNome.Text;
            pessoaF.DataNascimento = Convert.ToDateTime(dtPessoaFDataNascimento.Text);
            pessoaF.Rg = txPessoaFRg.Text;
            pessoaF.Cpf = txPessoaFCpf.Text;
            pessoaF.Enderecoo.Cidade = txPessoaFCidade.Text;
            pessoaF.Enderecoo.Bairro = txPessoaFBairro.Text;
            pessoaF.Enderecoo.Rua = txPessoaFRua.Text;
            pessoaF.Enderecoo.Numero = Convert.ToInt32(txPessoaFNumero.Text);
            pessoaF.Enderecoo.Complemento = txPessoaFComplemento.Text;
            int indexDadoProcurado = PessoaFisica.FindIndex(c => c.Cpf == pessoaF.Cpf);
            if (indexDadoProcurado == -1)
            {
                this.PessoaFisica.Add(pessoaF);
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                this.PessoaFisica[indexDadoProcurado] = pessoaF;
                MessageBox.Show("Editado com sucesso");
            }
            CarregarLista();
            LimparCampos();
            
        }

        private void lbEditavel_Click(object sender, EventArgs e)
        {

        }

        private void btPessoaFLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void CarregarLista()
        {
            dgPessoaFLista.Rows.Clear();
            foreach (var item in PessoaFisica)
            {
                dgPessoaFLista.Rows.Add(item.Nome, item.DataNascimento, item.Rg, item.Cpf, item.Enderecoo.Cidade, item.Enderecoo.Bairro, item.Enderecoo.Rua, item.Enderecoo.Numero, item.Enderecoo.Complemento);
            }
            dgPessoaFLista.Refresh();
        }
        private void LimparCampos()
        {
            txPessoaFNome.Text = String.Empty;
            dtPessoaFDataNascimento.Text = String.Empty;
            txPessoaFRg.Text = String.Empty;
            txPessoaFCpf.Text = String.Empty;
            txPessoaFCidade.Text = String.Empty;
            txPessoaFBairro.Text = String.Empty;
            txPessoaFRua.Text = String.Empty;
            txPessoaFNumero.Text = String.Empty;
            txPessoaFComplemento.Text = String.Empty;
        }

        private void dgPessoaFLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.ColumnIndex;

            if (indice == 3)
            {
                PessoaFisica pessoaF = this.PessoaFisica[e.RowIndex];
                CarregaFormulario(pessoaF);
            }
            else if (indice == 4)
            {
                PessoaFisica pessoaF = this.PessoaFisica[e.RowIndex];
                this.PessoaFisica.Remove(pessoaF);
                MessageBox.Show("Removido com sucesso");
                CarregarLista();
            }
        }
        private void CarregaFormulario(PessoaFisica pessoaF)
        {
            this.txPessoaFNome.Text = pessoaF.Nome;
            this.dtPessoaFDataNascimento.Text = pessoaF.DataNascimento.ToString();
            this.txPessoaFRg.Text = pessoaF.Rg;
            this.txPessoaFCpf.Text = pessoaF.Cpf;
            this.txPessoaFCidade.Text = pessoaF.Enderecoo.Cidade;
            this.txPessoaFBairro.Text = pessoaF.Enderecoo.Bairro;
            this.txPessoaFRua.Text = pessoaF.Enderecoo.Rua;
            this.txPessoaFNumero.Text = pessoaF.Enderecoo.Numero.ToString();
            this.txPessoaFComplemento.Text = pessoaF.Enderecoo.Complemento;
        }
    }
}