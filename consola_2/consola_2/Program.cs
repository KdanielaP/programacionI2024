using static consola_2.consola_2;

namespace consola_2;

internal class Program
{
    static void Main(string[] args)

    {
        // Crear instancias para probar las clases
        Persona persona = new Persona("Juan", "Perez", new DateTime(1990, 5, 15), "123456789", "Calle 123");
        Alumno alumno = new Alumno("Maria", "Garcia", new DateTime(1995, 8, 20), "987654321", "Avenida 456", "ABC123", new DateTime(2020, 3, 10));
        Profesor profesor = new Profesor("Pedro", "Lopez", new DateTime(1980, 10, 7), "55555555", "Plaza Principal", "Matemáticas", 2000);

        // Imprimir información de las instancias en la consola
        Console.WriteLine("Información de la persona:");
        Console.WriteLine("Nombre: " + persona.Nombre);
        Console.WriteLine("Apellido: " + persona.Apellido);
        Console.WriteLine("Fecha de nacimiento: " + persona.FechaNacimiento.ToShortDateString());
        Console.WriteLine("Teléfono: " + persona.Telefono);
        Console.WriteLine("Dirección: " + persona.Direccion);

        Console.WriteLine();

        Console.WriteLine("Información del alumno:");
        Console.WriteLine("Nombre: " + alumno.Nombre);
        Console.WriteLine("Apellido: " + alumno.Apellido);
        Console.WriteLine("Fecha de nacimiento: " + alumno.FechaNacimiento.ToShortDateString());
        Console.WriteLine("Teléfono: " + alumno.Telefono);
        Console.WriteLine("Dirección: " + alumno.Direccion);
        Console.WriteLine("Carnet: " + alumno.Carnet);
        Console.WriteLine("Fecha de ingreso: " + alumno.FechaIngreso.ToShortDateString());

        Console.WriteLine();

        Console.WriteLine("Información del profesor:");
        Console.WriteLine("Nombre: " + profesor.Nombre);
        Console.WriteLine("Apellido: " + profesor.Apellido);
        Console.WriteLine("Fecha de nacimiento: " + profesor.FechaNacimiento.ToShortDateString());
        Console.WriteLine("Teléfono: " + profesor.Telefono);
        Console.WriteLine("Dirección: " + profesor.Direccion);
        Console.WriteLine("Materia: " + profesor.Materia);
        Console.WriteLine("Salario: " + profesor.Salario);
    }
}
 
