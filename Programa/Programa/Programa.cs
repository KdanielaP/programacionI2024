using Programa;
namespace Programa
{
    internal class Program;
    static void Main(string[] args)
    {
        Persona persona = new Persona("Juan", "Perez", new DateTime(1990, 5, 15), "123456789", "Calle Principal");
        Alumno alumno = new Alumno("Maria", "Gomez", new DateTime(2000, 10, 20), "987654321", "Avenida Central", "20210001", new DateTime(2021, 9, 1));
        Profesor profesor = new Profesor("Pedro", "Martinez", new DateTime(1985, 3, 10), "456789123", "Calle Secundaria", "Matemáticas", 10);


        Console.WriteLine(Program.GetContenido());
    }

}
