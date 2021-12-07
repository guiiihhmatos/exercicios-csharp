using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double preco, quantidade, comissao;
            int codigo;

            Console.WriteLine("Boa tarde funcionário.");
            Console.WriteLine();
            Console.Write("Qual seu nome : ");
            nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o código da peça vendida : ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o valor da peça : R$ ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite a quantidade vendida desse produto efetuada pela sua pessoa : ");
            quantidade = double.Parse(Console.ReadLine());

            Console.Clear();

            comissao = (quantidade * preco) * 0.05;

            Console.WriteLine($"Parabéns vendedor, sua comissão sobre a venda do produto {nome} foi de R$ {comissao} reais.");
            Console.WriteLine();
            Console.WriteLine("Vamos dar o seu melhor!!");
            Console.ReadKey();
        }
    }
}
