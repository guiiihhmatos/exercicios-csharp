using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100; i <= 200; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
