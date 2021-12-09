using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado;

            int opcao = Menu();

            switch(opcao)
            {
                case 1:
                Console.WriteLine("Somar");
                Console.WriteLine();
                
                Console.Write("Digite o valor do 1° Número : ");
                numero1 = double.Parse(Console.ReadLine());
                
                Console.Write("Digite o valor do 2° Número : ");
                numero2 = double.Parse(Console.ReadLine());

                resultado = numero1 + numero2;
                Console.WriteLine("Resultado = " + resultado);
                break;

                case 2:
                Console.WriteLine("Subrair");
                Console.WriteLine();
                
                Console.Write("Digite o valor do 1° Número : ");
                numero1 = double.Parse(Console.ReadLine());
                
                Console.Write("Digite o valor do 2° Número : ");
                numero2 = double.Parse(Console.ReadLine());

                resultado = numero1 - numero2;
                Console.WriteLine("Resultado = " + resultado);
                break;

                case 3:
                Console.WriteLine("Multiplicação");
                Console.WriteLine();
                
                Console.Write("Digite o valor do 1° Número : ");
                numero1 = double.Parse(Console.ReadLine());
                
                Console.Write("Digite o valor do 2° Número : ");
                numero2 = double.Parse(Console.ReadLine());

                resultado = numero1 * numero2;
                Console.WriteLine("Resultado = " + resultado);
                break;

                case 4:
                Console.WriteLine("Divisão");
                Console.WriteLine();
                
                Console.Write("Digite o valor do 1° Número : ");
                numero1 = double.Parse(Console.ReadLine());
                
                Console.Write("Digite o valor do 2° Número : ");
                numero2 = double.Parse(Console.ReadLine());

                resultado = numero1 / numero2;
                Console.WriteLine("Resultado = " + resultado);
                break;

                default:

                Console.WriteLine("Você digitou uma opção inválida");
                
                break;
            }        
        }
        private static int Menu()
        {
            Console.WriteLine("Escolha a conta que deseja fazer");
            Console.WriteLine();
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine();
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            return opcao;
        }
        
    }
}
