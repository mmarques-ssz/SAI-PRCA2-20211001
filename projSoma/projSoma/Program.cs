using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            n1 = entrarInt("Digite o valor de n1: ", 5, 10);
            n2 = entrarInt("Digite o valor de n2: ", 10, 20);

            Console.WriteLine("Resultado da soma de {0} com {1} é {2}", n1, n2, calcular(n1, n2));
        }

        static int entrarInt(string msg, int li, int ls)
        {
            int x;
            do
            {
               Console.Write(msg);
               x = int.Parse(Console.ReadLine());
            }
            while (x < li || x > ls);
            return x;
        }

        static int calcular(int x, int y)
        {
            return (x + y);
        }
    }
}
