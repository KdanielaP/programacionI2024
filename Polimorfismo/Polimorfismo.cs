using System;


namespace Polimorfismo
{
    internal class Polimorfismo
    {
    }
}
class Auto
{
    public List<string> Reparaciones { get; set; }

    public Auto()
    {
        Reparaciones = new List<string>();
    }

    public void HistoriaDeReparaciones()
    {
        foreach (string reparacion in Reparaciones)
        {
            Console.WriteLine(reparacion);
        }
    }
}

class BMW : Auto
{
    public void reparar(string reparacion)
    {
        Reparaciones.Add(reparacion);
        using (StreamWriter writer = new StreamWriter("reparaciones.txt", true))
        {
            writer.WriteLine(reparacion);
        }
    }

    public void LeerArchivo()
    {
        Console.WriteLine("Historia de reparaciones:");
        using (StreamReader reader = new StreamReader("reparaciones.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
