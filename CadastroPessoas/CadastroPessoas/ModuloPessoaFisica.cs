using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class ModuloPessoaFisica : Tela
    {
        OperacoesPessoaFisica crud = new OperacoesPessoaFisica();
        public ModuloPessoaFisica() : base("Pessoa Fisica")
        {
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }
        private void Escolha(int escolha)
        {
            Console.Clear();
            this.Cabecalho();
            switch (escolha)
            {
                case 1:
                    crud.Create();
                    break;
                case 2:
                    crud.Read();
                    break;
                case 3:
                    crud.Update();
                    break;
                case 4:
                    crud.Delete();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
        private int Opcoes()
        {
            int escolha;
            Console.WriteLine("[1] -Cadastrar" +
                            "\n[2] -Listar" +
                            "\n[3] -Editar" +
                            "\n[4] -Deletar" +
                            "\n[0] -Sair");
            Console.WriteLine("**********************************************************");
            Console.Write("Opção:");
            escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }
    }
}
