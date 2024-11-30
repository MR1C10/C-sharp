using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_2
{
    public static class PlusTabuada
    {
        public static void Run()
        {
            Console.WriteLine("\ndigite o número a ser multiplicado:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nNúmero escolhido {x}\n");
            int y;
            y = x * 1;
            Console.WriteLine(y);
            y = x * 2;
            Console.WriteLine(y);
            y = x * 3;
            Console.WriteLine(y);
            y = x * 4;
            Console.WriteLine(y);
            y = x * 5;
            Console.WriteLine(y);
            y = x * 6;
            Console.WriteLine(y);
            y = x * 7;
            Console.WriteLine(y);
            y = x * 8;
            Console.WriteLine(y);
            y = x * 9;
            Console.WriteLine(y);
            y = x * 10;
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
