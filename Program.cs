using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {


            //Fibonnaci
            int a = 0, b = 1, c = 0;

            //Entrada de dados
            Console.Write("Digite quantos valores: ");
            int valores = int.Parse(Console.ReadLine());



            Console.WriteLine("Sequência Fibonacci com " + " " + valores + " valores: ");

            //Estrutura de repetição
            for (int i = 0; i < valores; i++)
            {
                if(i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }
                c = a + b;
                a = b;
                b = c;
            }

            Console.ReadKey();

        }
    }
}