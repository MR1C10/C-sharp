using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX03
    {
        public static void Run()
        {
            Console.WriteLine("\n3. Crie um algoritmo que leia dois numero, some o número dois aos valores lidos,\r\ne mostre os valores resultantes");

            Console.Write("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite mais um número");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{x} + 2 é {x + 2}");
            Console.WriteLine($"\n{y} + 2 é {y + 2}");

            Console.ReadKey();



        }
    }
}
