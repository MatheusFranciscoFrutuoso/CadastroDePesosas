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

        public PessoaJuridica(string nome, DateTime dataNasc, string ie, string cnpj, Endereco endereco)
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
            this.Ie = ie;
            this.Cnpj = cnpj;
            this.Endereco = endereco;
        }
        public PessoaJuridica()
        {

        }
        public override string ToString()
        {
            return $"\n\tNome: {Nome}\n\tData de Nascimento: {DataNascimento.ToString("MM/dd/yyyy")}\n\tIE: {Ie}\n\tCNPJ: {Cnpj}\n\tEndereço: {Endereco}";
        }
    }
}
