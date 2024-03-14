using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    internal class Numeros
    {

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
                    if (i % 2 != 0) // Si el número no es par
                    {
                        continue; // Saltar al siguiente número sin imprimir nada
                    }
                    Console.WriteLine(i);
                }
            }
        }
    }
}
