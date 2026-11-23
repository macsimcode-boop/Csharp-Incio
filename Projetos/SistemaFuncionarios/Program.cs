using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        int mais = 0;
        double Total = 0;

        Console.WriteLine("Quantos funcionários existem?");
        int funcionarios = int.Parse(Console.ReadLine());


        for (int i = 0; i < funcionarios; i++)
        {

            Console.WriteLine($"Digite o nome do {i + 1}º funcionario ");
            string Nome = Console.ReadLine();

            Console.WriteLine($"Quantas horas trabalhou o {Nome} funcionario ");
            int Horas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quanto ganha por hora o {Nome} funcionario ");
            double ValorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double Salario = Horas * ValorH;

            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salario: {Salario.ToString("F2", CultureInfo.InvariantCulture)}EUR");

            Total += Salario;
            
            if (Salario > 1000)
            {
                mais += 1;

            }


         }

        Console.WriteLine($"Total pago: {Total.ToString("F2", CultureInfo.InvariantCulture)}EUR");
        Console.WriteLine($"Quantidade de funcionarios que ganharam mais de 1000EUR:{mais} ");

    }
} 
