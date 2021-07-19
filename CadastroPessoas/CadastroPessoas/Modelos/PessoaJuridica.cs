using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.Modelos
{
    class PessoaJuridica : Pessoa
    {
        public string Ie { get; set; }
        public string Cnpj { get; set; }

        public PessoaJuridica(string nome, DateTime dataNasc, string ie, string cnpj)
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
            this.Ie = ie;
            this.Cnpj = cnpj;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\t| Data de criação: {DataNascimento}\t| IE: {Ie}\t| CNPJ: {Cnpj}";
        }

    }
}
