using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX06
    {
        public static void Run()
        {
            Console.WriteLine("\n6. Desenvolva um algoritmo que leia um número e mostre o seu resultado\r\nmultiplicado por 3, se o resultado for maior que 15. ");

            Console.WriteLine("\nDigite um número: \n");
            int x = int.Parse(Console.ReadLine());

            int y = x * 3;

            if (y > 15) 
            {
                Console.WriteLine(y);
            }
        }
    }
}
