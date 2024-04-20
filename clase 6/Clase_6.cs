using System;


namespace clase_6
{
    internal class Clase_6
    {
    }
    class Program

    {
        static void Main()
        {
            Console.Write("Ingrese un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 1)
            {
                Console.WriteLine("El número ingresado no es válido.");
                return;
            }

            Console.WriteLine("Números pares desde 1 hasta " + numero + ":");
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}