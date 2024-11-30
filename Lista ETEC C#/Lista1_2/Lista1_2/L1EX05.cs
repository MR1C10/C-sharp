using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX05
    {
        public static void Run()
        {
            Console.WriteLine("\n5. Crie um algoritmo que leia dois números, subtraia os seus valores (num1-num2)\r\n, some ao resultado o número 10 e mostre o valor da operação em vídeo. ");

            Console.WriteLine("\nDigite um número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite um número");
            int num2 = int.Parse(Console.ReadLine());

            int x = num1 - num2;
            int y = x + 10;

            Console.WriteLine($"{num1} - {num2} = {x}\n{x} + 10 = {y}");

            Console.ReadKey();

        }
    }
}
