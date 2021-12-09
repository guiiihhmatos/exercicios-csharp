using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.Write("Digite o 1° número : ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número : ");
            numero2 = int.Parse(Console.ReadLine());

            int opcao = Menu();

            if(opcao != 4)
            {
                switch (opcao)
                {
                    case 1: Multiplo(numero1, numero2); break;

                    case 2: Pares(numero1, numero2); break;

                    case 3: Media(numero1, numero2); break;

                    default: Console.WriteLine("Opção inválida."); break;
                }
                
            } else {

                Console.WriteLine("Você saiu, programa encerrado!!");

            }
        }
        private static int Menu()
        {
            int opcao;

            Console.Clear();
            Console.WriteLine("Escolha a sua opção desejada");
            Console.WriteLine();
            Console.WriteLine("1 – Verificar se um dos números lidos é ou não múltiplo do outro");
            Console.WriteLine("2 – Verificar se os dois números lidos são pares ");
            Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7.");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();
            opcao = int.Parse(Console.ReadLine());

            Console.Clear();
            return opcao;
        }
        private static void Multiplo(int n1, int n2)
        {
            if (n1 >= n2)
            {
                if (n1 % n2 == 0) Console.WriteLine("Eles são múltiplos.");

                else Console.WriteLine("Eles não são múltiplos");

            }
            else
            {

                if (n2 % n1 == 0) Console.WriteLine("Eles são múltiplos.");

                else Console.WriteLine("Eles não são múltiplos");

            }
        }
        private static void Pares(int n1, int n2)
        {
            if ((n1 % 2 == 0) && (n2 % 2 == 0)) Console.WriteLine("Eles são pares.");

            else Console.WriteLine("Eles não são pares.");

        }
        private static void Media(int n1, int n2)
        {
            double media;

            media = (n1 + n2) / 2;

            if (media >= 7) Console.WriteLine($"A Média dos dois é maior ou igual a 7. Média = {media}");

            else Console.WriteLine($"A Média dos dois é menor do que 7. Média = {media}");
        }
    }
}
