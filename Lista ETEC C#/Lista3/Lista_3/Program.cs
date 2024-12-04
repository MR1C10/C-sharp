using System;
using Lista_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício para executar (1-10):");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                L3EX01.Run();
                break;
            case 2:
                L3EX02.Run();
                break;
            case 3:
                L3EX03.Run();
                break;
            case 4:
                L3EX04.Run();
                break;
            case 5:
                L3EX05.Run();
                break;
            case 6:
                L3EX06.Run();
                break;
            case 7:
                L3EX07.Run();
                break;
            case 8:
                L3EX08.Run();
                break;
            case 9:
                L3EX09.Run();
                break;
            case 10:
                L3EX10.Run();
                break;
            default:
                Console.WriteLine("Exercício não encontrado.");
                break;
        }
    }
}