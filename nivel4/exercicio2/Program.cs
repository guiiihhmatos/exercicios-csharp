using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double resultado = 1;

            Console.Write("Digite um número : ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                for (int i = 1; i < numero; numero--)
                {

                    resultado = numero * resultado;

                }

                Console.WriteLine($"Resultado do fatorial do seu número = {resultado}");
                Console.ReadKey();

            }
            else
            {

                Console.WriteLine("Numéro negativo não tem fatorial");

            }
        }
    }
}
