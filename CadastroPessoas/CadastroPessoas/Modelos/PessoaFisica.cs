using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.Modelos
{
    class PessoaFisica : Pessoa
    {
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public PessoaFisica(string nome, DateTime dataNasc, string Rg, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
            this.Rg = Rg;
            this.Cpf = cpf;
        }
        public PessoaFisica(string nome)
        {
            this.Nome = nome;
        }
    }
}
