using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, menor, maior, contador = 2;
            int qtdeNumeros;
            bool verificador = true;

            Console.WriteLine("Verificação do número maior e menor");
            Console.WriteLine();

        VOLTAR:
            Console.Write("Digite quantos números você quer digitar. Mínimo 3 : ");
            qtdeNumeros = int.Parse(Console.ReadLine());

            if (qtdeNumeros > 0)
            {
                    Console.Write("Digite o primeiro valor : ");
                    numero = double.Parse(Console.ReadLine());

                    maior = numero;
                    menor = numero;

                    verificador = false;

                if (verificador == false)
                {
                    while (contador <= qtdeNumeros)
                    {
                        Console.Clear();
                        Console.Write($"Digite o valor do {contador}° número : ");
                        numero = double.Parse(Console.ReadLine());

                        if (numero > maior)
                        {
                            maior = numero;
                        }

                        if (numero < menor)
                        {
                            menor = numero;
                        }
                        
                        contador++;
                    }
                }

                Console.WriteLine($"O maior número é = {maior}. O menor número é = {menor}.");
                Console.ReadKey();
            }
            else
            {

                Console.Clear();
                Console.WriteLine("Digite um valor maior do que 0");
                Console.WriteLine("Aperte qualquer tecla para refazer");
                Console.ReadKey();
                Console.Clear();
                goto VOLTAR;
            }
        }
    }
}
