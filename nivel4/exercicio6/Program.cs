using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAlunos, i;
            double nota, media = 0;

            Console.Write("Quantos alunos fizeram a prova : ");
            numeroAlunos = int.Parse(Console.ReadLine());

            Console.Clear();

            for (i = 1; i <= numeroAlunos; i++)
            {
            VOLTAR:
                Console.Write($"Digite a nota do {i}° aluno : ");
                nota = double.Parse(Console.ReadLine());

                if (nota > 0 && nota <= 10)
                {
                    media += nota;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Notas válidas de 0 a 10");
                    Console.WriteLine("Aperte qualquer tecla do seu teclado para digitar novamente essa nota");
                    Console.ReadKey();
                    Console.Clear();
                    goto VOLTAR;
                }

                Console.Clear();
            }

            media = media / numeroAlunos;

            Console.WriteLine($"A média das notas da turma é {media}");
            Console.ReadKey();
        }
    }
}
