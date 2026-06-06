using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos produtos deseja comprar?");
        int QuantidadeP = int.Parse(Console.ReadLine());

        double Total = 0;

        for (int i = 0; i < QuantidadeP; i++)
        {
            Console.WriteLine("Qual o nome do produto?");
            string Nome = Console.ReadLine();

            Console.WriteLine("Qual o preco do produto?");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantas unidades do produto deseja?");
            int quantidade = int.Parse(Console.ReadLine());

            Total += preco * quantidade;
        }

        double desconto = 0;
        double Final;

        if (Total > 100)
        {
            desconto = Total * 0.10;
            Final = Total - desconto;
        }
        else
        {
            Final = Total;
        }

        Console.WriteLine($"Total: {Total.ToString("F2", CultureInfo.InvariantCulture)} EUR");
        Console.WriteLine($"Desconto: {desconto.ToString("F2", CultureInfo.InvariantCulture)} EUR");
        Console.WriteLine($"Total Final: {Final.ToString("F2", CultureInfo.InvariantCulture)} EUR");
    }
}
