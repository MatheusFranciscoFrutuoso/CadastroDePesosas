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
        PessoaFisicaForm pessoaF = new PessoaFisicaForm();
        PessoaJuridicaForm pessoaJ = new PessoaJuridicaForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btPessoaF_Click(object sender, EventArgs e)
        {
            pessoaF.Show();
        }

        private void btPessoaJ_Click(object sender, EventArgs e)
        {
            pessoaJ.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {

        }
    }
}
