using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class L1EX10
    {
        public static void Run()
        {
            Console.WriteLine("\n10. Crie um algoritmo que leia um número, divida o seu valor por dois e atribua o\r\nresultado da operação a duas variáveis diferentes, soma a uma das variáveis o\r\nnúmero três e a outra o número cinco, ao final, mostre o valor das duas\r\nvariáveis. ");

            Console.WriteLine("\nDigite um número:");
            int x = int.Parse(Console.ReadLine());

            int y = x / 2;
            int a = y;
            int b = y;
            a = a + 3;
            b = b + 5;

            Console.WriteLine($"{x} / 2 = {y}\n{y} + 3 = {a}\n{y} + 5 = {b}");

            Console.ReadKey();
        }
    }
}
