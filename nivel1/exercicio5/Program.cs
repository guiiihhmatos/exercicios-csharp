using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahren, celsius;

            Console.WriteLine("Transformação de temperatura");
            Console.WriteLine();
            Console.WriteLine("Transformando temperatura de Celsius pra Fahreinheit");
            Console.WriteLine();

            Console.Write("Digite a temperatura em Graus Celsius : ");
            celsius = double.Parse(Console.ReadLine());

            fahren = Math.Round((9 * celsius + 160) / 5, 2);

            Console.WriteLine("A temperatura em Fahreinheit é de {0} °F", fahren);
            Console.ReadKey();
        }
    }
}
