# Macsim
Estudando programação 

using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos produtos deseja comprar?");
        int quantidadeP = int.Parse(Console.ReadLine());

        double total = 0;

        for (int i = 0; i < quantidadeP; i++)
        {
            Console.WriteLine("Nome do produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preco do produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            total += preco * quantidade;
        }

        double desconto = 0;

        if (total > 100)
        {
            desconto = total * 0.10;
        }

        double final = total - desconto;

        Console.WriteLine($"\nTotal: {total.ToString("F2", CultureInfo.InvariantCulture)} EUR");
        Console.WriteLine($"Desconto: {desconto.ToString("F2", CultureInfo.InvariantCulture)} EUR");
        Console.WriteLine($"Total final: {final.ToString("F2", CultureInfo.InvariantCulture)} EUR");
    }
}
