using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX05
    {
        public static void Run() 
        {
            Console.WriteLine("\n5. Elabore um algoritmo que leia dois números e mostre os seus valores\r\nmultiplicados por 10 se a soma dos valores originais for menor que 20.");

            Console.WriteLine("\nDigite um número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite um número: ");
            int y = int.Parse(Console.ReadLine());

            int z = x + y;

            if (z < 20) 
            {
                z = z * 10;
                Console.WriteLine($"\n" + z);
            }

        }
    }
}
