using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX07
    {
        public static void Run()
        {
            Console.WriteLine("\n7. Criando uma tabuada. Crie um algoritmo que leia um número e mostre\r\ncomo resultado a tabuada de multiplicação do número lido. ");

            Console.WriteLine("\nDigite um número");
            int x = int.Parse(Console.ReadLine());

            int a = x * 1;
            int b = x * 2;
            int c = x * 3;
            int d = x * 4;
            int e = x * 5;
            int f = x * 6;
            int g = x * 7;
            int h = x * 8;
            int i = x * 9;
            int j = x * 10;

            Console.WriteLine($"\nAqui está a tabuada do número: {x}\n{a}\n{b}\n{c}\n{d}\n{e}\n{f}\n{g}\n{h}\n{i}\n{j}");

            Console.ReadKey();

        }
    }
}
