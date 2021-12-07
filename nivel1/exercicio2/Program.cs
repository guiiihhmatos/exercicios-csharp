using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar = 5.65, real, dinheiro;

            Console.Write("Digite o valor em dolár para ser convertido em Real : U$ ");
            dinheiro = double.Parse(Console.ReadLine());

            real = dinheiro * dolar;

            Console.Clear();
            Console.WriteLine($"O valor que você tem em dolar = U$ {dinheiro} vale R$ {real} reais.");
            Console.ReadKey();

        }
    }
}
