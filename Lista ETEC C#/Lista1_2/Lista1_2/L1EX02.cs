using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX02
    {
        public static void Run()
        {
            Console.WriteLine("\n2. Descreva um algoritmo que leia um número, subtraia do seu valor o numero\r\ntrês, multiplique por dois e exiba o resultado.\n");

            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());
            
            int y = x - 3;
            int z = y * 2;

            Console.WriteLine($"\n({x} - 3) * 2 = {z}");

            Console.ReadKey();

        }
    }
}
