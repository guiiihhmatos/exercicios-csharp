using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Vendo todos os relacionamentos possíveis entre dois números inteiros. ");
            Console.WriteLine();

            Console.Write("Digite o Primeiro número inteiro : ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo número inteiro : ");
            numero2 = int.Parse(Console.ReadLine());
            
            Console.Clear();
            
            if(numero1 == numero2) Console.WriteLine("Números são iguais");
            if(numero1 >= numero2) Console.WriteLine("O primeiro número é maior ou igual ao segundo");
            if(numero1 > numero2) Console.WriteLine("O primeiro número é maior do que o segundo");
            if(numero2 >= numero1) Console.WriteLine("O segundo número é maior ou igual ao primeiro");
            if(numero2 > numero1) Console.WriteLine("O segundo número é maior do que o Primeiro");
            if(numero2 <= numero1) Console.WriteLine("O segundo número é menor ou igual ao primeiro");
            if(numero2 < numero1) Console.WriteLine("O segundo número é menor do que o Primeiro");
            if(numero1 <= numero2) Console.WriteLine("O primeiro número é maior ou igual ao segundo");
            if(numero1 < numero2) Console.WriteLine("O primeiro número é maior do que o segundo");
            if (numero1 != numero2) Console.WriteLine("Os número são diferentes");

            Console.ReadKey();
        }
    }
}
