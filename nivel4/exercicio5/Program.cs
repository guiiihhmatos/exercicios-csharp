using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i, resultado;

            Console.WriteLine("Tabuada");
            Console.WriteLine();
            Console.Write("Digite um número : ");
            numero = int.Parse(Console.ReadLine());

            for(i = 1; i <= 10; i++)
            {
                resultado = i * numero;
                Console.WriteLine($"{numero} X {i} = {resultado}");

            }

            Console.ReadKey();
        }
    }
}
