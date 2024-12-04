using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    static class L3EX04
    {
        public static void Run()
        {
            Console.WriteLine("\n4. Crie um algoritmo que leia três números some 5 aos seus valores e mostre os\r\nvalores resultantes maiores que 10. ");
            
            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite outro número:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite mais um número:");
            int z = int.Parse(Console.ReadLine());

            x = x + 5;
            y = y + 5;
            z = z + 5;

            if (x > 10)
            {
                Console.WriteLine($"\n{x} é maior que 10.");
            }
            if (y > 10)
            {
                Console.WriteLine($"\n{y} é maior que 10.");
            }
            if (z > 10)
            {
                Console.WriteLine($"\n{z} é maior que 10.");
            }
        }
    }
}
