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
    public partial class OperacoesPessoaFisica : Form
    {
        public List<PessoaFisica> PessoaFisica { get; set; }
        //public string Nome { get; set; }
        //public DateTime DataNascimento { get; set; }
        //public string RG { get; set; }
        //public string CPF { get; set; }
        //public string Cidade { get; set; }
        //public string Bairro { get; set; }
        //public string Rua { get; set; }
        //public int Numero { get; set; }
        //public string Complemento { get; set; }

        public OperacoesPessoaFisica()
        {
            InitializeComponent();
            PessoaFisica = new List<PessoaFisica>();
            //lvPessoaFLista.AutoGenerateColumns = false;
            //lvPessoaFLista.AllowUserToAddRows = false;
        }

        private void OperacoesPessoaFisica_Load(object sender, EventArgs e)
        {

        }

        private void txPessoaFNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPessoaFSalvar_Click(object sender, EventArgs e)
        {
            PessoaFisica pessoaF = new PessoaFisica();
            string Nome = txPessoaFNome.Text;
            DateTime DataNascimento = Convert.ToDateTime(dtPessoaFDataNascimento.Text);
            string RG = txPessoaFRg.Text;
            string CPF = txPessoaFCpf.Text;
            string Cidade = txPessoaFCidade.Text;
            string Bairro = txPessoaFBairro.Text;
            string Rua = txPessoaFRua.Text;
            int Numero = Convert.ToInt32(txPessoaFNumero.Text);
            string Complemento = txPessoaFComplemento.Text;
            this.PessoaFisica.Add(pessoaF); 
        }
        //private void CarregarLista()
        //{
        //    lvPessoaFLista.Clear();
        //    foreach (var item in Categoria)
        //    {
        //        lvPessoaFLista.Add(item.Id, item.Nome, item.Descricao);
        //    }
        //    lvPessoaFLista.Refresh();
        //}

        //private void lvPessoaFLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int indice = e.ColumnIndex;

        //    if (indice == 3)
        //    {
        //        PessoaFisica pessoaF = this.PessoaFisica[e.RowIndex];

        //    }
        //    else if (indice == 4)
        //    {
        //        PessoaFisica categoria = this.PessoaFisica[e.RowIndex];
        //        this.PessoaFisica.Remove(categoria);
        //        MessageBox.Show("Removido com sucesso");
        //        CarregarLista();
        //    }
        }
       
    
}
