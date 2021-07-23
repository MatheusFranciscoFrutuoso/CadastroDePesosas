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
            dgPessoaJLista.AutoGenerateColumns = false;
            dgPessoaJLista.AllowUserToAddRows = false;
            CarregarLista();
        }

        private void btPessoaJSalvar_Click(object sender, EventArgs e)
        {
            PessoaJuridica pessoaJ = new PessoaJuridica();
            pessoaJ.Nome = txPessoaJNome.Text;
            pessoaJ.DataNascimento = Convert.ToDateTime(dtPessoaJDataNascimento.Text);
            pessoaJ.Ie = txPessoaJIe.Text;
            pessoaJ.Cnpj = txPessoaJCnpj.Text;
            pessoaJ.Endereco.Cidade = txPessoaJCidade.Text;
            pessoaJ.Endereco.Bairro = txPessoaJBairro.Text;
            pessoaJ.Endereco.Rua = txPessoaJRua.Text;
            pessoaJ.Endereco.Numero = Convert.ToInt32(txPessoaJNumero.Text);
            pessoaJ.Endereco.Complemento = txPessoaJComplemento.Text;
            int indexDadoProcurado = PessoaJuridica.FindIndex(c => c.Cnpj == pessoaJ.Cnpj);
            if (indexDadoProcurado == -1)
            {
                this.PessoaJuridica.Add(pessoaJ);
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                this.PessoaJuridica[indexDadoProcurado] = pessoaJ;
                MessageBox.Show("Editado com sucesso");
            }
            CarregarLista();
            LimparCampos();
        }

        private void btPessoaJLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void CarregarLista()
        {
            dgPessoaJLista.Rows.Clear();
            foreach (var item in PessoaJuridica)
            {
                dgPessoaJLista.Rows.Add(item.Nome, item.DataNascimento, item.Ie, item.Cnpj, item.Endereco.Cidade, item.Endereco.Bairro, item.Endereco.Rua, item.Endereco.Numero, item.Endereco.Complemento);
            }
            dgPessoaJLista.Refresh();
        }
        private void LimparCampos()
        {
            txPessoaJNome.Text = String.Empty;
            dtPessoaJDataNascimento.Text = String.Empty;
            txPessoaJIe.Text = String.Empty;
            txPessoaJCnpj.Text = String.Empty;
            txPessoaJCidade.Text = String.Empty;
            txPessoaJBairro.Text = String.Empty;
            txPessoaJRua.Text = String.Empty;
            txPessoaJNumero.Text = String.Empty;
            txPessoaJComplemento.Text = String.Empty;
        }

        private void dgPessoaJLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.ColumnIndex;

            if (indice == 10)
            {
                PessoaJuridica pessoaJ = this.PessoaJuridica[e.RowIndex];
                CarregaFormulario(pessoaJ);
            }
            else if (indice == 9)
            {
                PessoaJuridica pessoaJ = this.PessoaJuridica[e.RowIndex];
                this.PessoaJuridica.Remove(pessoaJ);
                MessageBox.Show("Removido com sucesso");
                CarregarLista();
            }
        }
        private void CarregaFormulario(PessoaJuridica pessoaJ)
        {
            this.txPessoaJNome.Text = pessoaJ.Nome;
            this.dtPessoaJDataNascimento.Text = pessoaJ.DataNascimento.ToString();
            this.txPessoaJIe.Text = pessoaJ.Ie;
            this.txPessoaJCnpj.Text = pessoaJ.Cnpj;
            this.txPessoaJCidade.Text = pessoaJ.Endereco.Cidade;
            this.txPessoaJBairro.Text = pessoaJ.Endereco.Bairro;
            this.txPessoaJRua.Text = pessoaJ.Endereco.Rua;
            this.txPessoaJNumero.Text = pessoaJ.Endereco.Numero.ToString();
            this.txPessoaJComplemento.Text = pessoaJ.Endereco.Complemento;
        }

        private void btPessoaJLimpar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btPessoaJVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }
