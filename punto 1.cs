namespace Documento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el número 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el número 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el número 3");
            int num3 = int.Parse(Console.ReadLine());

            int menor = num1;
            if (num2 < menor)
                menor = num2;
            if (num3 < menor)
                menor = num3;

            int mayor = num1;
            if (num2 > mayor)
                mayor = num2;
            if (num3 > mayor)
                mayor = num3;

            Console.WriteLine("El número menor es: " + menor);
            Console.WriteLine("El número mayor es: " + mayor);
        }
    }
}
