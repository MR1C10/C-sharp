using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX06
    {
        public static void Run()
        {
            Console.WriteLine("\n6. Descreva um algoritmo que leia um número, subtraia do seu valor o número\r\ntrês, leia outro número e some ao seu valor o número dois, some os resultados\r\ndas operações realizadas com os números lidos , subtrai do resultado o número\r\n1 e mostre em vídeo o valor final da operação.");

            Console.WriteLine("\nDigite um número");
            int x = int.Parse(Console.ReadLine());
            int y = x - 3;

            Console.WriteLine("\nDigite outro número");
            int z = int.Parse(Console.ReadLine());
            int w = z + 2;

            int t = y + w;
            int n = z + x;
            int m = t + n;
            int c = m - 1;

            Console.WriteLine($"\nResutado{c}");

            Console.ReadKey();
        }
    }
}
