using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX08
    {
        public static void Run()
        {
            Console.WriteLine("\n8. Elaborar um algoritmo que leia três números some 10 ao primeiro, subtraia\r\ncinco do segundo e multiplique o terceiro por dois, após efetuar estas\r\noperações mostre o resultado das operações. ");

            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite outro número:");
            int y = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nDigite mais um número:");
            int z = int.Parse(Console.ReadLine());

            int a = x + 10;
            int b = y - 5;
            int c = z * 2;

            Console.WriteLine($"\n{x} + 10 = {a}\n{y} - 5 = {b}\n{z} * 2 = {c}");

            Console.ReadKey();

        }
    }
}
