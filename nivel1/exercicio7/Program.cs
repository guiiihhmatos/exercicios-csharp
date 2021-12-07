using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, altura;

            Console.WriteLine("Calculo do volume da lata de óleo");
            Console.WriteLine();

            Console.Write("Digite o valor da altura da sua lata/Garrafa de óleo em metros : ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o valor do raio da sua lata/garrafa de óleo : ");
            raio = double.Parse(Console.ReadLine());

            Console.Clear();

            volume = Math.Round(3.14159 * raio * raio * altura, 2);

            Console.WriteLine("O valor do volume da sua lata/Garrafa de óleo é = {0} ", volume);
            Console.ReadKey();
        }
    }
}
