using System;

namespace CadastraProduto
{
    class Validacao
    {
        public static string ValidaString()
        {
            string dado = string.Empty;

            do
            {
                dado = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(dado))
                {
                    break;
                }
                else
                {
                    Console.Write("Dado invalido. Digite novamente: ");
                }
            } while (true);

            return dado;
        }

        public static int ValidaInteiro()
        {
            int dado = 0;

            do
            {
                try
                {
                    dado = Convert.ToInt32(Console.ReadLine());
                    if (dado >= 0)
                    {
                        return dado;
                    }
                    else
                    {
                        Console.Write("Número invalido. Digite novamente: ");
                    }
                }
                catch (Exception)
                {
                    Console.Write("Dado invalido. Digite novamente: ");
                }
            } while (true);
        }
        public static decimal ValidaDecimal()
        {
            decimal dado = 0.00m;

            do
            {
                try
                {
                    dado = decimal.Parse(Console.ReadLine().Replace('.', ','));
                    
                    if (dado >= 0)
                    {
                        return dado;
                    }
                    else
                    {
                        Console.Write("Número invalido. Digite novamente: R$");
                    }
                }
                catch (Exception)
                {
                    Console.Write("Dado invalido. Digite novamente: R$ ");
                }
            } while (true);
        }

        public static string ValidaConfirmacao()
        {
            string dado = string.Empty;
            do
            {
                dado = Console.ReadLine().Trim().ToLower();
                if (dado.Equals("s") || dado.Equals("n"))
                {
                    return dado;
                }
                else
                {
                    Console.Write("Dado invalido. Digite apenas [S/N]: ");
                }
            } while (true);
        }

        public static int ValidaMenuLista()
        {
            int dado = 0;
            do
            {
                try
                {
                    dado = Convert.ToInt32(Console.ReadLine().Trim());
                    if(dado >= 0 && dado < 3)
                    {
                        return dado;
                    }
                    else
                    {
                        Console.Write("Opção invalida. Digite novamente: ");
                    }
                    
                }
                catch (Exception)
                {
                    Console.Write("Dado invalido. Digite novamente: ");
                }
            } while (true);
        }

    }
}
