using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX09
    {
        public static void Run() 
        {
            Console.WriteLine("\n9. Crie um algoritmo que leia um numero e mostre o seu valor dividido por 2, se o\r\nresultado for maior que 20.");

            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            int y = x / 2;

            if (y > 20)
            {
                Console.WriteLine(y);
            }
        }
    }
}
