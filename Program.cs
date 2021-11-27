using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double lucro = 0;
                double compra = 0;

                Console.Write("Informe o valor de compra do produto: ");
                compra += double.Parse(Console.ReadLine());

                if (compra <= 0)
                {
                    Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                    Console.WriteLine("Programa Encerrado.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Informe o percentual de lucro: ");
                    lucro += double.Parse(Console.ReadLine());
                }

                if (lucro < 0)
                {
                    Console.WriteLine("Informe um valor igual ou maior do que 0 (Zero)");
                    Console.WriteLine("Programa Encerrado.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    compra += compra * (lucro / 100);
                }

                    Console.WriteLine("O Valor de venda é: " + compra.ToString("C"));                
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir por Zero");
            }
             catch(FormatException)
            {
                Console.WriteLine("Caractere Invalido");
            }            
            catch(Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            finally
            {
                Console.WriteLine("Programa Encerrado.");
            }
            Console.ReadKey();
        }
    }
}
