using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0, maior, menor, numero;

            Console.Write("Digite o primeiro valor : ");
            numero = double.Parse(Console.ReadLine());

            maior = numero;
            menor = numero;
            media += numero;

            for(int i = 2; i <= 10; i++)
            {
                VOLTAR:
                Console.Clear();
                Console.Write($"Digite o {i}° número : ");
                numero = double.Parse(Console.ReadLine());

                if(numero > 0)
                {
                    media += numero;

                    if(numero > maior)
                    {
                        maior = numero;
                    } 

                    if(numero < menor)
                    {
                        menor = numero;
                    }


                } else {

                    Console.Clear();
                    Console.WriteLine("Você digitou um número negativo, so é permitido números positivos");
                    Console.WriteLine("Aperte qualquer tecla para digitar novamente.");
                    Console.ReadKey();
                    goto VOLTAR;
                }

            }

            media = media / 10;
            Console.WriteLine($"Média dos números = {media}");
            Console.WriteLine($"Maior número = {maior}");
            Console.WriteLine($"Menor número = {menor}");

            Console.ReadKey();
        }
    }
}
