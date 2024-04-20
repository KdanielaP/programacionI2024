class Program
{
    static void Main()
    {
        BMW bmw = new BMW();

        Console.WriteLine("Ingrese la reparación realizada:");
        string reparacion = Console.ReadLine();

        bmw.reparar(reparacion);

        bmw.HistoriaDeReparaciones();
        bmw.LeerArchivo();
    }
}