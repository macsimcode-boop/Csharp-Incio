namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = { 4, 8, 2, 6, 10 };

            Console.WriteLine("Digite um número:");
            int procurado = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == procurado)
                {

                    encontrado = true;

                }

            }

            if (encontrado && procurado % 2 == 0)
            {

                Console.WriteLine("O número existe e é par");
            }
            else if(encontrado) 
            {
                Console.WriteLine("O número existe mas é impar");
            }
            else
            {
                Console.WriteLine("O número não existe");
            }
        
        
        }
    }
}
