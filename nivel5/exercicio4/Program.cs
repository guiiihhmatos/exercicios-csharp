using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde, i, contador1 = 0, contador3 = 0, contador4 = 0;

            Console.Write($"Digite o valor de números que você quer armazenar no array (máximo de 100) : ");
            qtde = int.Parse(Console.ReadLine());

            if (qtde <= 100)
            {

                int[] numeros = new int[qtde];

                for(i = 0; i < qtde; i++)
                {
                    Console.Write($"Digite o número do indíce {i} : ");
                    numeros[i] = int.Parse(Console.ReadLine());

                    Console.Clear();
                }

                for(i = 0; i < qtde; i++)
                {
                    switch (numeros[i])
                    {
                        case 1: contador1++; break;

                        case 3: contador3++; break;

                        case 4: contador4++; break;
                    }
                }

                Console.WriteLine($"O número 1 repetiu : {contador1} vezes.");
                Console.WriteLine($"O número 3 repetiu : {contador3} vezes.");
                Console.WriteLine($"O número 4 repetiu : {contador4} vezes.");

            } else {

                Console.Clear();
                Console.WriteLine("Você digitou um número acima de 100. Programa encerrado.");

            }

            
            Console.ReadKey();
        }
    }
}
