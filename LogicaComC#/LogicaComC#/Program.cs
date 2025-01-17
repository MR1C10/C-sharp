using System;
using Exercicios;

class program 
{
    public static void Main(string[] args)
    {
        while (true)
        {
            int opcao;

            ExerRun.Exercicios();
            Console.WriteLine("\nQual exercicio deseja ver?");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Opção 1");
                    break;
            }
        }
    }
}