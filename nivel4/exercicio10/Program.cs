using System;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int C, N, salarioTotal;
            bool verificador = true;
            string opcao;

            while (verificador == true)
            {
                int E, salario;

                salarioTotal = 0;

                Console.Write("Digite o código do trabalhador : ");
                C = int.Parse(Console.ReadLine());

                Console.Write("Digite quantas horas você trabalhou : ");
                N = int.Parse(Console.ReadLine());

                if(N <= 50)
                {
                    salario = 10 * N;
                    E = 0;

                } else {

                    salario = 10 * 50;
                    E = 20 * (N - 50);

                }
                
                salarioTotal = salario + E;
                Console.WriteLine($"Salario total Com o excendente incluso = R$ {salarioTotal}. Excendente = R$ {E}");
                Console.ReadKey();

                opcao = Menu();
                Console.Clear();

                switch(opcao.ToUpper())
                {
                    case "S":

                    verificador = false;

                    break;

                    case "N":

                    verificador = true; //Não precisa colocar, coloquei pra não deixar em branco

                    break;

                    default:

                    Console.WriteLine("Opção inválida!! Programa encerrado.");
                    verificador = false;

                    break;
                }

            }

            Console.ReadKey();
        }

        public static string Menu()
        {
            string opcao;

            Console.Clear();
            Console.WriteLine("Você deseja encerrar o programa ?");
            Console.WriteLine();
            Console.WriteLine("S - Sim");
            Console.WriteLine("N - Não");
            Console.WriteLine();
            
            opcao = Console.ReadLine();
            return opcao;
        }

    }
}
