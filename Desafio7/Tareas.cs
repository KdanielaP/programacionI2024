using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio7
{
    internal class Tareas
    {
    }
}

class Program
{
    static List<string> tareas = new List<string>();

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarTareas();
                    break;
                case 2:
                    AgregarTarea();
                    break;
                case 3:
                    EliminarTarea();
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    static void MostrarTareas()
    {
        Console.WriteLine("Lista de tareas:");
        foreach (var tarea in tareas)
        {
            Console.WriteLine(tarea);
        }
    }

    static void AgregarTarea()
    {
        Console.WriteLine("Introduce la nueva tarea:");
        string nuevaTarea = Console.ReadLine();
        tareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada con éxito.");
    }

    static void EliminarTarea()
    {
        Console.WriteLine("Indica el índice de la tarea que deseas eliminar:");
        int indice = Convert.ToInt32(Console.ReadLine());

        if (indice >= 0 && indice < tareas.Count)
        {
            tareas.RemoveAt(indice);
            Console.WriteLine("Tarea eliminada con éxito.");
        }
        else
        {
            Console.WriteLine("Índice inválido. Inténtelo de nuevo.");
        }
    }
}