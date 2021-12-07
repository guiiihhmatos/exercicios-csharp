using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0, nota, recuperacao;

            Console.WriteLine("Verficador de aprovação do aluno");
    
            for(int i = 1; i <= 4; i++)
            {
                VOLTAR:
                Console.WriteLine();
                Console.Write($"Digite a {i}° nota :  ");
                nota = double.Parse(Console.ReadLine());

                if(nota >= 0 && nota <=10)
                {
                    media += nota;

                } else {
                    
                    Console.Clear();
                    Console.WriteLine("Você digitou uma nota inválida. Notas aceitas de 0 a 10");
                    Console.WriteLine("Aperte qualquer botão para digiar a nota novamente");
                    Console.ReadKey();
                    goto VOLTAR;
                }
                
            }

            media = media / 4;
            
            if(media >= 7)
            {
                Console.Clear();
                Console.WriteLine($"Parabéns, você foi aprovado com a média = {media}");

            } else {

                VOLTAR2:
                Console.Clear();
                Console.WriteLine($"Você não foi aprovado, sua média ficou = {media}");
                Console.WriteLine();
                Console.Write("Favor digitar a sua nota da recuperação : ");
                recuperacao = double.Parse(Console.ReadLine());

                if(recuperacao >= 0 && recuperacao <= 10)
                {
                    media = (media + recuperacao) / 2;
                    Console.Clear();
                    
                    if(media >= 7) Console.WriteLine($"Parabéns!! Você foi aprovado. Sua média ficou = {media}");
                    else Console.WriteLine($"Você não foi aprovado. Sua média após a recuperação ficou = {media}");

                } else {

                    Console.WriteLine("Você digitou a nota da recuperação inválida. Notas aceitas de 0 a 10");
                    Console.WriteLine("Aperte qualquer botão para digiar a nota novamente");
                    Console.ReadKey();
                    goto VOLTAR2;
                }
            }
            
            Console.ReadKey();
        }
    }
}
