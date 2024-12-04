using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX01
    {
        public static void Run()
        {
            Console.WriteLine("\n1. Elabore um algoritmo que leia um número e\r\nmostre o seu valor, se ele for menor que cinco. ");

            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            if (x < 5)
            {
                Console.WriteLine($"\nNúmero:{x}");
            }
        }
    }
}