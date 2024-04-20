class Program
{
    static void Main()
    {
        NotificacionEmail emailNotif = new NotificacionEmail();
        emailNotif.Notifica();

        NotificacionWhatsap whatsappNotif = new NotificacionWhatsap();
        whatsappNotif.Notifica();

        NotificacionSMS smsNotif = new NotificacionSMS();
        smsNotif.Notifica();
    }
}