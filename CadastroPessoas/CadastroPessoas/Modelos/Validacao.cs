using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.Modelos
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
                    if (dado >= 0 && dado < 3)
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
        public static int[] ValidaData()
        {
            string dado = "";
            string[] data;
            int[] dataint = new int[3];
            do {
                try
                {

                    dado = Console.ReadLine();
                    data = dado.Split('/');
                    for (int i = 0; i < 3; i++)
                    {
                        dataint[i] = Convert.ToInt32(data[i]);
                    }
                    if (dataint[0] >= 1 && dataint[0] <= 30)
                    {
                        if (dataint[1] >= 1 && dataint[1] <= 12)
                        {
                            if(dataint[2] >= 1000 && dataint[2] <= 9999)
                            {
                                return dataint;
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite uma data no formato: 'DD/MM/YYYY'");
                }
               
            
            } while (true);
        }
        public static string[] ValidaEndereco()
        {
            string endereco = string.Empty;
            string[] enderecoSeparado;
            string[] enderecoFinal = new string[5];

            do
            {
                endereco = Console.ReadLine();
                enderecoSeparado = endereco.Split(',');
                for (int i = 0; i < enderecoSeparado.Length; i++)
                {
                    enderecoFinal[i] = enderecoSeparado[i];

                }
                try
                {
                    if (Convert.ToInt32(enderecoFinal[3].Trim()) < 0)
                    {
                        throw new Exception();
                    }

                    for (int i = 0; i < enderecoFinal.Length-1; i++)
                {
                        if (!string.IsNullOrEmpty(enderecoFinal[i]))
                        {
                            enderecoFinal[i] = enderecoFinal[i].Trim();
                            
                        }
                        else
                        {
                            throw new Exception();
                        }
                            
                }
                    return enderecoFinal;

                }
                catch (Exception)
                {

                    Console.WriteLine("Digite um endereço válido(Cidade*, Bairro*, Rua*, Número*, Complemento):");
                }
            } while (true);
        }

    }
}
