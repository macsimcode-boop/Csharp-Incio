using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos produtos deseja comprar");
        int QuantidadeP = int.Parse(Console.ReadLine());

        double desconto;
        double Final;

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

        if (Total > 100)
        {
            desconto = Total * 0.10;
            Final = Total - desconto;
        }
        else
        {
            Final = Total;
            desconto = 0;
        }

        Console.WriteLine($"Total:{Total.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Desconto: {desconto.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Total Final: {Final.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}

