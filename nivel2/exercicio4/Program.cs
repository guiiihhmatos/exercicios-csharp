using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;

            Console.WriteLine("Verificado o maior número entres os dois digitados");
            Console.WriteLine();

            Console.Write("Digite o valor do primeiro número : ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo número : ");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            if(numero1 > numero2) Console.WriteLine($"O primeiro valor digitado é o maior. Valor do primeiro número = {numero1}");
            else if(numero2 > numero1) Console.WriteLine($"O segundo valor digitado é o maior. Valor do segundo número = {numero2}");
            else Console.WriteLine("O valor dos números são iguais.");

            Console.ReadKey();   
        }
    }
}
