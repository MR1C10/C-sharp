using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX01
    {
        public static void Run()
        {
            Console.WriteLine("1. Elaborar um algoritmo que leia um número, some ao seu valor o número cinco\r\ne exiba o resultado da operação.\n");

            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());
            int y = x + 5;

            Console.WriteLine($"\n{x} + 5 = {y}");

            Console.ReadKey();

        }
    }
}