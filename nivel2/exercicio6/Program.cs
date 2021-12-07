using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.WriteLine("Verificador de código");
            Console.WriteLine();

            Console.Write("Digite o número do seu código : ");
            codigo = int.Parse(Console.ReadLine());

            if(codigo == 1 || codigo == 2 || codigo == 3)
            {
                Console.Clear();
                Console.WriteLine("Código válido");
                Console.WriteLine();

                switch(codigo)
                {
                    case 1:
                    Console.WriteLine("Código Um");
                    break;

                    case 2:
                    Console.WriteLine("Código Dois");
                    break;

                    case 3:
                    Console.WriteLine("Código Três");
                    break;
                }

            } else {

                Console.Clear();
                Console.WriteLine("Código inválido");
            }

            Console.ReadKey();
        }
    }
}
