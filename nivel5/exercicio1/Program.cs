using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde, i;

            Console.Write("Quantos núemros você deseja adicionar no vetor : ");
            qtde = int.Parse(Console.ReadLine());

            int[] numero = new int[qtde];

            for(i = 0; i < qtde; i++)
            {
                Console.Write($"Digite o valor do número no indice {i} no array : ");
                numero[i] = int.Parse(Console.ReadLine());

            }

            Console.Clear();
            
            for(i = qtde - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}° Indice = {1}",(i), numero[i]);
            }
            
            Console.ReadKey();
        }
    }
}
