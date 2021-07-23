using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoas.Modelos;

namespace CadastroPessoas
{
    public class OperacoesPessoaJuridica : Crud
    {
        public OperacoesPessoaJuridica()
        {
            this.createOperation = Cadastrar;
            this.readOperation = Listar;
            this.updateOperation = Alterar;
            this.deleteOperation = Deletar;
        }
        public void Cadastrar()
        {
            bool igual = true;
            PessoaJuridica pessoaJ = new PessoaJuridica();
            Console.WriteLine("Insira o nome: ");
            pessoaJ.Nome = Validacao.ValidaString();
            Console.WriteLine("Insira a data de nascimento/fundação(DD/MM/YYYY):");
            int[] vetorData = Validacao.ValidaData();
            pessoaJ.DataNascimento = new DateTime(vetorData[2], vetorData[1], vetorData[0]);
            Console.WriteLine("Digite um endereço válido(Cidade*, Bairro*, Rua*, Número*, Complemento):");
            string[] vetorEndereco = new string[5];
            vetorEndereco = Validacao.ValidaEndereco();
            pessoaJ.Endereco = new Endereco(vetorEndereco[0], vetorEndereco[1], vetorEndereco[2], Convert.ToInt32(vetorEndereco[3].Trim()), vetorEndereco[4]);
            pessoaJ.Cnpj = string.Empty;
            Console.WriteLine("Insira o IE: ");
            pessoaJ.Ie = Validacao.ValidaString();
            Console.WriteLine("Insira o CNPJ: ");
            do
            {
                pessoaJ.Cnpj = Validacao.ValidaString();
                igual = Compara(pessoaJ.Cnpj);
                if (igual)
                {
                    Console.Write("Digite um CNPJ Válido:");
                }

            } while (igual);
            lista.Add(pessoaJ);
        }
        public void Listar()
        {
            Console.WriteLine("Listagem Pessoas Jurídicas Cadastradas");
            foreach (var item in lista)
            {
                if (item.GetType() == typeof(PessoaJuridica))
                {
                    Console.WriteLine(item);
                    PausarImpressao();
                }
            }
            Console.WriteLine("Nada cadastrado!");
            PausarImpressao();
        }
        private void Alterar()
        {
            PessoaJuridica pessoaJ = new PessoaJuridica();
            Listar();
            Console.WriteLine("Digite um Cpf para Alterar:");
            string cnpj = Console.ReadLine();
            foreach (PessoaJuridica pj in lista)
            {
                if (cnpj.Equals(pj.Cnpj))
                {
                    pessoaJ = pj;
                    Console.WriteLine("Pessoa Localizada!");
                    PausarImpressao();
                    break;
                }
                Console.WriteLine("Vendedor não encontrado!");
                PausarImpressao();
            }
            if (pessoaJ.Cnpj.Equals(string.Empty))
            {
                Console.WriteLine("Tem nada aqui");
                PausarImpressao();
            }
            else
            {
                CadastroAlterar(pessoaJ);
            }
        }
        private void Deletar()
        {
            Listar();
            Console.Write("Digite o cnpj da pessoa que deseja deletar: ");
            string cnpj = Console.ReadLine();
            bool encontrado = false;
            foreach (PessoaJuridica pj in lista)
            {
                if (pj.Cnpj.Equals(cnpj))
                {
                    encontrado = true;
                    lista.Remove(pj);
                    Console.WriteLine("Pessoa deletado\n");
                    PausarImpressao();
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Pessoa não encontrada.");
                PausarImpressao();
            }
        }
        public bool Compara(string dado)
        {
            bool igual = false;
            foreach (object item in lista)
            {
                if (item.GetType() == typeof(PessoaJuridica))
                {
                    PessoaJuridica j = (PessoaJuridica)item;
                    if (dado == j.Cnpj)
                    {
                        igual = true;
                    }
                }
            }
            return igual;
        }
        private void CadastroAlterar(PessoaJuridica pessoaj)
        {
            Console.WriteLine("Insira o nome:");
            pessoaj.Nome = Console.ReadLine();
            Console.WriteLine("Insira o CPF:");
            pessoaj.Cnpj = Console.ReadLine();
            Console.WriteLine("Insira o RG:");
            pessoaj.Ie = Console.ReadLine();
        }
    }
}
