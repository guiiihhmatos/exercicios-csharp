using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, diferenca;

            Console.WriteLine("Diferença do maior para o menor");
            Console.WriteLine();
            
            Console.Write("Digite o primeiro número : ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número : ");
            numero2 = double.Parse(Console.ReadLine());

            if(numero1 > numero2)
            {
                diferenca = numero1 - numero2;
                Console.WriteLine("A diferença do maior para o menor é = {0} ", diferenca);

            } else if(numero2 > numero1)
            {
                diferenca = numero2 - numero1;
                Console.WriteLine("A diferença do maior para o menor é = {0} ", diferenca);

            } else {

                Console.WriteLine("Os dois números são iguais");

            }

            Console.ReadKey();
        }
    }
}
