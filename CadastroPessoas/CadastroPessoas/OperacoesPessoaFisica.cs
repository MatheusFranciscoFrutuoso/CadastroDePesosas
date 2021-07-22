using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoas.Modelos;

namespace CadastroPessoas
{
    public class OperacoesPessoaFisica : Crud
    {
        public OperacoesPessoaFisica()
        {
            this.createOperation = Cadastrar;
            this.readOperation = Listar;
            this.updateOperation = Alterar;
            this.deleteOperation = Deletar;
        }
        public void Cadastrar()
        {
            bool igual = true;
            PessoaFisica pessoaF = new PessoaFisica();
            Console.WriteLine("Insira o nome: ");
            pessoaF.Nome = Validacao.ValidaString();
            Console.WriteLine("Insira a data de nascimento/fundação(DD/MM/YYYY):");
            int[] vetorData = Validacao.ValidaData();
            pessoaF.DataNascimento = new DateTime(vetorData[2], vetorData[1], vetorData[0]);
            Console.WriteLine("Digite um endereço válido(Cidade*, Bairro*, Rua*, Número*, Complemento):");
            string[] vetorEndereco = new string[5];
            vetorEndereco = Validacao.ValidaEndereco();
            pessoaF.Enderecoo = new Endereco(vetorEndereco[0], vetorEndereco[1], vetorEndereco[2], Convert.ToInt32(vetorEndereco[3].Trim()), vetorEndereco[4]);
            Console.WriteLine("Insira o RG: ");
            pessoaF.Rg = Validacao.ValidaString();
            pessoaF.Cpf = string.Empty;
            Console.WriteLine("Insira o CPF: ");
            do
            {
                pessoaF.Cpf = Validacao.ValidaString();
                igual = Compara(pessoaF.Cpf);
                if (igual)
                {
                    Console.Write("Digite um CPF Válido:");
                }
            } while (igual);
            lista.Add(pessoaF);
        }
        public void Listar()
        {
            Console.WriteLine("Listagem Pessoas Fisicas Cadastradas");
            foreach (var item in lista)
            {
                if (item.GetType() == typeof(PessoaFisica))
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
            PessoaFisica pessoaF = new PessoaFisica();
            Listar();
            Console.WriteLine("Digite um Cpf para Alterar:");
            string cpf = Console.ReadLine();
            foreach (PessoaFisica pf in lista)
            {
                if (cpf.Equals(pf.Cpf))
                {
                    pessoaF = pf;
                    Console.WriteLine("Pessoa Localizada!");
                    PausarImpressao();
                    break;
                }
                Console.WriteLine("Vendedor não encontrado!");
                PausarImpressao();
            }
            if (pessoaF.Cpf.Equals(string.Empty))
            {
                Console.WriteLine("Tem ninguém aqui");
                PausarImpressao();
            }
            else
            {
                CadastroAlterar(pessoaF);
            }
        }
        private void Deletar()
        {
            Listar();
            Console.Write("Digite o cpf da pessoa que deseja deletar: ");
            string cpf = Console.ReadLine();
            bool encontrado = false;
            foreach (PessoaFisica pf in lista)
            {
                if (pf.Cpf.Equals(cpf))
                {
                    encontrado = true;
                    lista.Remove(pf);
                    Console.WriteLine("Pessoa deletado");
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
                if (item.GetType() == typeof(PessoaFisica))
                {
                    PessoaFisica f = (PessoaFisica)item;
                    if (dado == f.Cpf)
                    {
                        igual = true;
                    }
                }
            }
            return igual;
        }
        private void CadastroAlterar(PessoaFisica pessoaF)
        {
            Console.WriteLine("Insira o nome:");
            pessoaF.Nome = Console.ReadLine();
            Console.WriteLine("Insira o CPF:");
            pessoaF.Cpf = Console.ReadLine();
            Console.WriteLine("Insira o RG:");
            pessoaF.Rg = Console.ReadLine();
        }
    }
}
