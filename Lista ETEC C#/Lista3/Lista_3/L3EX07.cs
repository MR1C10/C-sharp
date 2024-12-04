using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX07
    {
        public static void Run() 
        {
            Console.WriteLine("\n7. Crie um algoritmo que leia três números, some seus valores e mostre o\r\nresultado se ele for maior que 20.");

            Console.WriteLine("\nDigite um número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite um número: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite um número: ");
            int z = int.Parse(Console.ReadLine());

            int a = x + y + z;

            if (a > 20) 
            {
                Console.WriteLine($"{a}");
            }
        }
    }
}
