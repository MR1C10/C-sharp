using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    public static class L3EX10
    {
        public static void Run() 
        {
            Console.WriteLine("\n10. Elabore um algoritmo que leia um número e mostre a tabuada do número lido\r\nse ele for menor que 10. ");

            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            if (x < 10) 
            {
                for (int i = 1; i <= 10;) 
                {
                    int a = i * x;
                    i++;
                    Console.WriteLine(a);
                }
            }
        }
    }
}