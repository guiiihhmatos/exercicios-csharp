using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int genero;
            double altura, pesoIdeal;

            VOLTAR:
            Console.WriteLine("Verifique o peso ideal de acordo com sua altura");
            Console.WriteLine();
            Console.WriteLine("Digite o número do seu genero de acordo coma a tabela");
            Console.WriteLine();
            Console.WriteLine("1 - Masculino");
            Console.WriteLine("2 - Feminino");
            Console.WriteLine();

            genero = int.Parse(Console.ReadLine());
            Console.Clear();

            if(genero == 1 || genero == 2)
            {
                VOLTAR2:
                Console.WriteLine("Digite a sua altura, utilize a medida em metros. Exemplo 1,80");
                Console.Write("Altura : ");
                altura = double.Parse(Console.ReadLine());
                Console.Clear();

                if(altura > 0.0 & altura <= 2.51)
                {

                    if(genero == 1)
                    {
                        pesoIdeal = (72.7 * altura) - 58;
                        Console.WriteLine($"De acordo com a sua altura, seu peso Ideal é {pesoIdeal}Kg"); 

                    } else {

                        pesoIdeal = (62.1 * altura) - 44.7;
                        Console.WriteLine($"De acordo com a sua altura, seu peso Ideal é {pesoIdeal}Kg");
                    }
                } else {

                    Console.WriteLine("Digite uma altura válida. 0.0 até 2.51");
                    Console.WriteLine("Aperte qualquer peça do teclado para digitar novamente");
                    Console.ReadKey();
                    goto VOLTAR2;

                }
            } else {

                Console.WriteLine("Você digitou uma opção inválida!!");
                Console.WriteLine("Aperte qualquer peça do teclado para digitar novamente");
                Console.ReadKey();
                goto VOLTAR;
            }
            
            Console.ReadKey();

        }
    }
}
