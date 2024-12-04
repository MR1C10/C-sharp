using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX08
    {
        public static void Run()
        {
            Console.WriteLine("\n8. Elabore um algoritmo que leia dois números e mostre os seus valores se eles\r\nforem iguais.");

            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite um número:");
            int y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine($"\n{x} e {y} são iguais.");
            }
        }
    }
}
