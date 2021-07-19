using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoas.Modelos;

namespace CadastroPessoas
{
    class Operacoes
    {
        List<object> ListaPessoas = new List<object>();


        public void Cadastrar(bool fisica)
        {
            Console.WriteLine("Insira o nome: ");
            string nome = Validacao.ValidaString();
            Console.WriteLine("Insira a data de nascimento/fundação(DD/MM/YYYY):");
            int[] vetorData = Validacao.ValidaData();
            DateTime data = new DateTime(vetorData[2], vetorData[1], vetorData[0]);
            Console.WriteLine("Digite um endereço válido(Cidade*, Bairro*, Rua*, Número*, Complemento):");
            string[] vetorEndereco = new string[5];
            vetorEndereco = Validacao.ValidaEndereco();
            //Console.WriteLine("Insira a cidade: ");
            //string cidade = Validacao.ValidaString();
            //Console.WriteLine("Insira a bairro: ");
            //string bairro = Validacao.ValidaString();
            //Console.WriteLine("Insira a rua: ");
            //string rua = Validacao.ValidaString();
            //Console.WriteLine("Insira a numero: ");
            //int numero = Validacao.ValidaInteiro();
            //Console.WriteLine("Insira a complemento: ");
            //string complemento = Validacao.ValidaString();
            Endereco endereco = new Endereco(vetorEndereco[0], vetorEndereco[1], vetorEndereco[2], Convert.ToInt32(vetorEndereco[3].Trim()), vetorEndereco[4]);
            if (fisica)
            {
                Console.WriteLine("Insira o RG: ");
                string rg = Validacao.ValidaString();
                Console.WriteLine("Insira o CPF: ");
                string cpf = Validacao.ValidaString();
                ListaPessoas.Add(new PessoaFisica(nome, data, rg, cpf, endereco));
            }
            else
            {
                Console.WriteLine("Insira o IE: ");
                string ie = Validacao.ValidaString();
                Console.WriteLine("Insira o CNPJ: ");
                string cnpj = Validacao.ValidaString();
                ListaPessoas.Add(new PessoaJuridica(nome, data, ie, cnpj, endereco));
            }
        }
        public void ListarPessoas(bool fisica)
        {

            if (fisica)
            {
                Console.WriteLine("Listagem Pessoas Fisicas Cadastradas");
                foreach (var item in ListaPessoas)
                {
                    if (item.GetType() == typeof(PessoaFisica))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("Listagem Pessoas Juridicas Cadastradas");
                foreach (var item in ListaPessoas)
                {
                    if (item.GetType() == typeof(PessoaJuridica))
                    {
                        Console.WriteLine(item);
                    }
                }
            }

        }
    }
}
