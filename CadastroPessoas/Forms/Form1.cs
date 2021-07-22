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
    public partial class Form1 : Form
    {
        PessoaFisica pessoaF = new PessoaFisica();
        OperacoesPessoaFisica operacaoPF = new OperacoesPessoaFisica();
        public Form1()
        {
            InitializeComponent();
            List<PessoaFisica> listaPF = new List<PessoaFisica>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btPessoaF_Click(object sender, EventArgs e)
        {
            operacaoPF.Show();
        }

        private void btPessoaJ_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {

        }
    }
}
