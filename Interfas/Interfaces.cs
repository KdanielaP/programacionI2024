using System;

namespace Interfas
{
    internal class Interfaces
    {
    }
}
public interface INotificable
{
    void Notifica();
}

public class NotificacionEmail : INotificable
{
    private string direccionCorreo;

    public NotificacionEmail()
    {
    }

    public void Notifica()
    {
        Console.Write("Ingrese la dirección de correo para la notificación por Email: ");
        direccionCorreo = Console.ReadLine();
        Console.WriteLine($"Enviando notificación por Email a la dirección: {direccionCorreo}");
    }
}

public class NotificacionWhatsap : INotificable
{
    private string numeroTelefono;

    public NotificacionWhatsap()
    {
    }

    public void Notifica()
    {
        Console.Write("Ingrese el número de teléfono para la notificación por Whatsapp: ");
        numeroTelefono = Console.ReadLine();
        Console.WriteLine($"Enviando notificación por Whatsapp al número: {numeroTelefono}");
    }
}

public class NotificacionSMS : INotificable
{
    private string numeroTelefono;

    public NotificacionSMS()
    {
    }

    public void Notifica()
    {
        Console.Write("Ingrese el número de teléfono para la notificación por SMS: ");
        numeroTelefono = Console.ReadLine();
        Console.WriteLine($"Enviando notificación por SMS al número: {numeroTelefono}");
    }
}

