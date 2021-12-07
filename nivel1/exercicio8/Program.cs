using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias, totalDias;

            Console.WriteLine("Calcular o total de dias que você viveu.");
            Console.WriteLine("");
            Console.WriteLine("--> Baseamos os meses em 30 dias");
            Console.WriteLine("--> Basemaos os anos em 365 dias");
            Console.WriteLine("");

            Console.Write("Digite a sua idade expressada em anos : ");
            anos = int.Parse(Console.ReadLine());

            Console.Write("Você tem {0} anos e quantos meses : ", anos);
            meses = int.Parse(Console.ReadLine());

            Console.Write("Você tem {0} anos, {1} meses e quantos dias : ", anos, meses);
            dias = int.Parse(Console.ReadLine());

            totalDias = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("Na sua vida toda, você viveu {0} dias ", totalDias);
            Console.ReadKey();
        }
    }
}
