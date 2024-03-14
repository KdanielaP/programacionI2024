using System;

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

        bool esPrimo = true;

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
        {
            Console.WriteLine("El número ingresado es primo.");
        }
        else
        {
            Console.WriteLine("El número ingresado no es primo.");
        }
    }
}