using System;

class Program
{
    static void Main()
    {
        int totalPuntajes = 0;
        int cantidadPuntajes = 0;

        while (true)
        {
            Console.Write("Ingrese el puntaje del alumno (entre 1 y 10) o 'fin' para terminar: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "fin")
            {
                if (cantidadPuntajes == 0)
                {
                    Console.WriteLine("No se ingresaron puntajes.");
                }
                else
                {
                    double promedio = (double)totalPuntajes / cantidadPuntajes;
                    Console.WriteLine("El puntaje promedio del alumno es: " + promedio.ToString("0.00"));
                }
                break; // Salir del bucle while
            }

            if (int.TryParse(input, out int puntaje) && puntaje >= 1 && puntaje <= 10)
            {
                totalPuntajes += puntaje;
                cantidadPuntajes++;
            }
            else
            {
                Console.WriteLine("Valor no válido. Debe ingresar un número entre 1 y 10.");
            }
        }
    }
}