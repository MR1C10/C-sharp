using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX03
    {
        public static void Run()
        {
            Console.WriteLine("\n3. Desenvolva um algoritmo que leia um número, subtraia de seu valor o número\r\n10 e mostre o resultado se ele for maior que três.");
            
            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            int y = x - 10;

            if (y > 3)
            {
                Console.WriteLine($"\n{y} é maior que 3.");
            }
        }
    }
}
