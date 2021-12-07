using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahren, celsius;

            Console.WriteLine("Transformação de temperatura");
            Console.WriteLine();
            Console.WriteLine("Transformando temperatura de Fahreinheit pra Celsius");
            Console.WriteLine();

            Console.Write("Digite a temperatura em Graus Fahreinheit : ");
            fahren = double.Parse(Console.ReadLine());

            celsius = Math.Round((fahren - 32) * 5 / 9, 2);

            Console.WriteLine("A temperatura em Celsius é de {0} °C", celsius);
            Console.ReadKey();
        }
    }
}
