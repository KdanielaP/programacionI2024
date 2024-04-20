using System;

using System;

public class Juego
{
    static int puntajeRecord = 0;
    static string jugadorRecord = "";

    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese nombre de usuario:");
        string nombreUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese contraseña:");
        string contrasena = Console.ReadLine();

        registrarUsuario(nombreUsuario, contrasena); // Registro de usuario
        iniciarSesion(nombreUsuario, contrasena); // Inicio de sesión

        Console.WriteLine("Ingrese puntaje obtenido:");
        int puntajeObtenido = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese nombre del jugador:");
        string nombreJugador = Console.ReadLine();
        actualizarPuntaje(puntajeObtenido, nombreJugador);
    }

    public static void registrarUsuario(string nombreUsuario, string contrasena)
    {
        // Aquí podrías guardar el nombre de usuario y contraseña en una base de datos o en una lista, pero por simplicidad utilizamos variables estáticas
    }

    public static void iniciarSesion(string nombreUsuario, string contrasena)
    {
        if (nombreUsuario.Equals("usuario1") && contrasena.Equals("1234"))
        {
            Console.WriteLine("Inicio de sesión exitoso");
        }
        else
        {
            Console.WriteLine("Nombre de usuario o contraseña incorrectos");
        }
    }

    public static void actualizarPuntaje(int puntajeObtenido, string nombreJugador)
    {
        if (puntajeObtenido > puntajeRecord)
        {
            puntajeRecord = puntajeObtenido;
            jugadorRecord = nombreJugador;
            Console.WriteLine("La nueva puntuación más alta es " + puntajeRecord);
            Console.WriteLine("La puntuación más alta fue lograda por " + jugadorRecord);
        }
        else
        {
            Console.WriteLine("La puntuación más alta de " + puntajeRecord + " no se ha podido superar, y aún está en manos de " + jugadorRecord);
        }
    }
}