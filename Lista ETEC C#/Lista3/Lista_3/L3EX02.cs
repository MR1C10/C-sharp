using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX02
    {
        public static void Run()
        {
            Console.WriteLine("\n2. Crie um algoritmo que leia um número, some ao seu valor cinco e mostre o\r\nresultado se ele for maior que dez. ");

            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            int y = x + 5;

            if (y > 10)
            {
                Console.WriteLine($"\nNúmero:{y}");
            }
        }
    }
}