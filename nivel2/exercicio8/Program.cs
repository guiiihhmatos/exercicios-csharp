using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, a, b;

            Console.WriteLine("Armazenamento de variável");
            Console.WriteLine("");

            Console.Write("Digite um valor inteiro : ");
            numero = int.Parse(Console.ReadLine());

            if(numero >= 0)
            {
                a = numero;
                Console.WriteLine("Número positivo armazenado na variável A = " + a);

            } else {

                b = numero;
                Console.WriteLine("Número positivo armazenado na variável B = " + b);
            
            }
            
            Console.ReadKey();
        }
    }
}
