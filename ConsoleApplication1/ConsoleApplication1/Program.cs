using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void mostrarOla()
        {
            Console.WriteLine("Olá - estou na função MostrarOla()");
        }

        static int dobro(int n)
        {
            return (n * 2);
        }

        static int areaRetangulo(int b, int h)
        {
            int x;
            x = b * h;
            return x;
        }

        static void Main(string[] args)
        {
            int p;

            Console.WriteLine("Estou na função Main()");
            mostrarOla();
            Console.WriteLine("Estou novamente na função Main()");
            Console.WriteLine("O dobro de 3 é {0}", dobro(3));
            mostrarOla();
            Console.WriteLine("A área de um retângulo com base 4 e altura 5 é {0}", areaRetangulo(4, 5));
            mostrarOla();

            Console.Write("Digite um número qualquer: ");
            p = int.Parse(Console.ReadLine());
            if (dobro(p) > 20)
                Console.WriteLine("O dobro de {0} é maior do que 20", p);
            else
                Console.WriteLine("O dobro de {0} não é maior do que 20", p);
        }
    }
}
