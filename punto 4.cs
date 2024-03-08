namespace Documento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NÚMEROS PRIMOS");
            Console.WriteLine("Ingrese el límite de los números:");

            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("Números primos del 2 al " + limite + ":");

            for (int numero = 2; numero <= limite; numero++)
            {
                bool esPrimo = true;

                for (int divisor = 2; divisor < numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
