using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double litrosUsados, distancia, velocidade, tempo;

            Console.WriteLine("Calcular a quantiade de Litros usados na viagem.");
            Console.WriteLine();
            Console.Write("Digite a velocidade média do seu carro ao longo da viagem : KM/H ");
            velocidade = double.Parse(Console.ReadLine());

            Console.Write("Digite o tempo gasto em horas para chegar ao destino : ");
            tempo = double.Parse(Console.ReadLine());

            distancia = velocidade * tempo;
            litrosUsados = Math.Round((distancia / 12), 2);

            Console.WriteLine($"Você gastou {litrosUsados} Litros nesse percuso todo. ");
            Console.ReadKey();
        }
    }
}
