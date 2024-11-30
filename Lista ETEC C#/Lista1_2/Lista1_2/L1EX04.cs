using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX04
    {
        public static void Run()
        {
            Console.WriteLine("\n4. Elabore um algoritmo que leia um valor numérico, e some ao seu valor o número\r\n10, leia um segundo valor, efetue a sua divisão por dois, e mostre os valores\r\nresultantes.");

            Console.Write("\nDigite um número:");
            int a = int.Parse(Console.ReadLine());

            int b = a + 10;

            Console.WriteLine("\nDigite mais um número:");
            int c = int.Parse(Console.ReadLine());

            int d = c / 2;

            Console.WriteLine($"\n{a} + 10 = {b}\n{c} / 2 = {d}");

            Console.ReadKey();

        }
    }
}
