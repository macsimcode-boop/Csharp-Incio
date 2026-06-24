namespace MyApp
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Digite quantos números tem o array");
            int quantidade = int.Parse(Console.ReadLine());

            int[] array = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                
                    Console.WriteLine($"Digite o {i + 1} numero");
                    array[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"O array é um Palindromo: {Palindromo(array)} ");
        }




            static bool Palindromo(int[] array)
            {
                int inicio = 0;
                int fim = array.Length - 1;

                while (inicio < fim)
                {
                    if (array[inicio] != array[fim])
                        return false;

                    inicio++;
                    fim--;
                }

                return true;
            }

        

    }   
}


