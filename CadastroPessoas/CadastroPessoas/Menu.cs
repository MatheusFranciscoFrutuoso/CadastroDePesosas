using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoas.Modelos;

namespace CadastroPessoas
{
    public class Menu : Tela
    {
        private ModuloPessoaFisica moduloPF;
        private ModuloPessoaJuridica moduloPJ;
        public Menu() : base("Bem-Vindo")
        {
            moduloPF = new ModuloPessoaFisica();
            moduloPJ = new ModuloPessoaJuridica();
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }
        private int Opcoes()
        {
            int escolha;
            Console.WriteLine("[1] - Modulo Pessoa Física" +
                            "\n[2] - Modulo Pessoa Jurídica" +
                            "\n[0] - Sair");
            Console.WriteLine("***********************************************************");
            Console.Write("Opção:");
            escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }
        private void Escolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    moduloPF.Executa();
                    break;
                case 2:
                    moduloPJ.Executa();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}

