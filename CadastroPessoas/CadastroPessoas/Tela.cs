using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public delegate int Opcoes();
    public delegate void Escolha(int escolha);
    public class Tela
    {
        private string _nomeTela = "";
        protected Opcoes funcaoOpcoes;
        protected Escolha funcaoEscolha;
        protected void Cabecalho()
        {
            Console.WriteLine($"************************{this._nomeTela}**************************" +
                            "\n**********************************************************");
        }
        public Tela(string nomeTela)
        {
            this._nomeTela = nomeTela;
        }
        public void Executa()
        {
            int escolha = 0;
            do
            {
                Console.Clear();
                Cabecalho();
                escolha = funcaoOpcoes();
                funcaoEscolha(escolha);
            } while (escolha != 0);
        }
    }
}
