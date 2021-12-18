using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[20];
            int[] idade = new int[20];

            for(int i = 0; i < 20; i++)
            {
                Console.Write($"Digite o nome da {i + 1}° Mulher : ");
                nome[i] = Console.ReadLine();

                Console.Write($"Digite a idade da {i + 1}° Mulher : ");
                idade[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            for(int i = 0; i < 20; i++)
            {
                if((idade[i] >= 18) && (idade[i] <= 20))
                {
                    Console.WriteLine($"Você está dentro da idade escolhida. Parabéns {nome[i]}");
                }
            }

            Console.ReadKey();
        }
    }
}
