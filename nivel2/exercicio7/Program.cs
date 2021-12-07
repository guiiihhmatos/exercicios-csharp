using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;
             
            Console.WriteLine("Verificando se é um triângulo"); 
            Console.WriteLine();

            Console.Write("Escreva o primeiro lado : ");
            lado1 = double.Parse(Console.ReadLine());

            Console.Write("Escreva o segundo lado : ");
            lado2 = double.Parse(Console.ReadLine());

            Console.Write("Escreva o terceiro lado : ");
            lado3 = double.Parse(Console.ReadLine());

            Console.Clear();

            if(lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2) {

                if(lado1 == lado2 && lado2 == lado3){

                    Console.WriteLine("Triângulo equilátero");

                } else if(lado1 == lado2 || lado2 == lado3 || lado3 == lado1){

                    Console.WriteLine("Triângulo isoceles");

                } else {

                     Console.WriteLine("Triângulo escaleno");

                }

            }else {

                 Console.WriteLine("Não é um triângulo");

            }

            Console.ReadKey();
        }
    }
}
