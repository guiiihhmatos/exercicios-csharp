using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int contadorPar = 0, contadorMultiplo = 0, i;

            for(i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o valor do indice {i} : ");
                numeros[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            for(i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    contadorPar++;
                }

                if(numeros[i] % 5 == 0)
                {
                    contadorMultiplo++;
                }
            }

            Console.WriteLine($"Você digitou {contadorPar} números pares.");
            Console.WriteLine($"Você digitou {contadorMultiplo} números múltiplos de 5.");

            Console.ReadKey();
        }
    }
}
