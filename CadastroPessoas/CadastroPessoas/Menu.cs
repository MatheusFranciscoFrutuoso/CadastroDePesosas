using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoas.Modelos;

namespace CadastroPessoas


{
    class Menu
    {
        Operacoes cadastrar = new Operacoes();
        public void CriarMenu()
        {
            Cabecalho();
            Rodape();
            Escolha();

        }

        public void Cabecalho()
        {
            System.Console.WriteLine("*********************  Havan Labs ***********************");
            System.Console.WriteLine("*********************  Bem-vindo ************************");
        }

        public void Rodape()
        {

            System.Console.WriteLine("\nEscolha um opção do menu:");
        }

        public void Opcoes()
        {
            System.Console.WriteLine("\n\t1-Cadastrar Pessoa Física");
            System.Console.WriteLine("\t2-Cadastrar Pessoa Jurídica");
            System.Console.WriteLine("\t3-Listar Pessoas Físicas");
            System.Console.WriteLine("\t4-Listar Pessoas Jurídicas");
            System.Console.WriteLine("\t0-Sair");
        }


        public void Escolha()
        {
            int opcao = 0;

            do
            {

                Opcoes();
                opcao = Validacao.ValidaInteiro();

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        cadastrar.Cadastrar(true);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        cadastrar.Cadastrar(false);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        cadastrar.ListarPessoas(true);
                        break;
                    case 4:
                        Console.Clear();
                        cadastrar.ListarPessoas(false);
                        break;
                    case 0:
                        Console.Clear();
                        System.Console.WriteLine("Saindo... Tecle ENTER para sair");
                        break;
                }
            } while (opcao != 0);

        }
    }
}

