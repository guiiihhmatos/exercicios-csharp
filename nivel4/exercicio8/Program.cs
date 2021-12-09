using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i % 10 == 0)
                {
                    Console.WriteLine($"{i} é múltiplo de 10.");
                }
            }
            
            Console.ReadKey();
        }
    }
}
