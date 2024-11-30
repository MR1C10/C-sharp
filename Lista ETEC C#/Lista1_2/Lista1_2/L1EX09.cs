using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX09
    {
        public static void Run()
        {
            Console.WriteLine("\n9. Descrever um algoritmo que leia um número, subtrai do seu valor o numero\r\ntrês, some o resultado ao número lido, e mostre o valor final da operação. ");

            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            int y = x - 3;
            int z = y + x;

            Console.WriteLine($"\n{x} - 3 = {y}\n{y} + {x} = {z}");

            Console.ReadKey();

        }
    }
}

