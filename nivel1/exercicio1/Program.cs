using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimo, maximo;
            double media;
            string nome;

            Console.WriteLine("Estoque");
            Console.WriteLine();
            Console.Write("Digite o nome do produto : ");
            nome = Console.ReadLine();

            Console.Write("Digite a quantidade mínima desse produto no estoque : ");
            minimo = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade máxima desse produto no estoque : ");
            maximo = int.Parse(Console.ReadLine());

            media = (minimo + maximo) / 2;

            Console.WriteLine($"A quantidade média do produto {nome} nesse estoque é = {media} ");
            Console.ReadKey();
        }
    }
}
