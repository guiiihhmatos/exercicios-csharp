using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Processar();
            Console.ReadKey();
        }
        private static void Processar()
        {
            int Idade;

            VOLTAR:
            Console.Write("Informe a sua idade: ");
            int.TryParse(Console.ReadLine(), out Idade);

            if (Idade >= 0)
            {
                if (Idade >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acesso permitdo!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Acesso Negado!!");
                }
            } else {

                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Você digitou uma idade negativa, por favor digite uma idade válida");
                Console.WriteLine();
                goto VOLTAR;
            }
        }
    }
}
