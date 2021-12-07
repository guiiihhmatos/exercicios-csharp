using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Verificador do número digitado, se está entre 0 e 9.");
            Console.WriteLine();

            Console.Write("Digite um número : ");
            numero = double.Parse(Console.ReadLine());

            if(numero >= 0 && numero <= 9)
            {
                Console.WriteLine();
                Console.WriteLine("Valor válido");
            } else {

                Console.WriteLine();
                Console.WriteLine("Valor inválido");
            }

            Console.ReadKey();
        }
    }
}
