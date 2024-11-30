using System;
using Lista1_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício para executar (1-11):");
        int escolha = int.Parse(Console.ReadLine());
        
        switch (escolha)
        {
            case 1:
                L1EX01.Run();
                break;
            case 2:
                L1EX02.Run();
                break;
            case 3:
                L1EX03.Run();
                break;
            case 4:
                L1EX04.Run();
                break;
            case 5:
                L1EX05.Run();
                break;
            case 6:
                L1EX06.Run();
                break;
            case 7:
                L1EX07.Run();
                break;
            case 8:
                L1EX08.Run();
                break;
            case 9:
                L1EX09.Run();
                break;
            case 10:
                L1EX10.Run();
                break;
            case 11:
                PlusTabuada.Run();
                break;

            default:
                Console.WriteLine("Exercício não encontrado.");
                break;
        }
    }
}