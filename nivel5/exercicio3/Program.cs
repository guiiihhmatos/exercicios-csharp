using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde, i, contador = 0;

            Console.Write("Digite o valor de números no array ( Valor máximo 50 ): ");
            qtde = int.Parse(Console.ReadLine());

            if (qtde <= 50)
            {

                int[] v1 = new int[qtde];
                int[] v2 = new int[qtde];

                for(i = 0; i < qtde; i++)
                {
                    Console.Write($"Digite o valor do array v1 no indíce {i} : ");
                    v1[i] = int.Parse(Console.ReadLine());

                    Console.Write($"Digite o valor do array v2 no indíce {i} : ");
                    v2[i] = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                }

                for(i = 0; i < qtde; i++)
                {
                    if(v1[i] == v2[i])
                    {
                        contador++;
                    }
                }

            } else {

                Console.Clear();
                Console.WriteLine("Você digitou um número acima de 50. Programa encerrado.");

            }

            Console.WriteLine("Quantidade de vezes que repete o valor dos indíces dos 2 arrays = {0}", contador);
            Console.ReadKey();
        }
    }
}
