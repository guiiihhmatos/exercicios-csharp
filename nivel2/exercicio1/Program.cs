using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3;

            Console.Write("Digite o primeiro número : ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número : ");
            numero2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número : ");
            numero3 = double.Parse(Console.ReadLine());

            if(numero1 > numero2 && numero1 > numero3)
            {
                if(numero2 > numero3) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero1, numero2, numero3);
                else Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero1, numero3, numero2);

            } else if(numero2 > numero1 && numero2 > numero3)
            {
                if(numero1 > numero3) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero2, numero1, numero3);
                else Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero2, numero3, numero1);

            } else if(numero3 > numero1 && numero3 > numero2)
            {
                if(numero1 > numero2) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero3, numero1, numero2);
                else Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero3, numero2, numero1);

            } else if(numero2 > numero1 && numero2 == numero3) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero2, numero3, numero1);
            else if(numero1 > numero2 && numero1 == numero3) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero1, numero3, numero2);
            else if(numero1 > numero3 && numero1 == numero2) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero1, numero2, numero3);
            else if(numero2 > numero3 && numero2 == numero1) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero2, numero1, numero3);
            else if(numero3 > numero1 && numero3 == numero2) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero3, numero2, numero1);
            else if(numero3 > numero2 && numero3 == numero1) Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero3, numero1, numero2);
            else Console.WriteLine("Ordem decrescente : {0}, {1}, {2} ", numero1, numero2, numero3);

            Console.ReadKey();
        }
    }
}
