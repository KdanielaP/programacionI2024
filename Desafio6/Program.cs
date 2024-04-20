class Program
{
    static void Main()
    {
        List<Caja> cajas = new List<Caja>();

        cajas.Add(new Caja(2, 3, 4));
        cajas.Add(new Caja(5, 6, 7));
        cajas.Add(new Caja(8, 9, 10));

        double totalVolumen = 0;

        foreach (Caja caja in cajas)
        {
            double volumen = caja.CalcularVolumen();
            totalVolumen += volumen;
            Console.WriteLine($"Volumen de la caja: {volumen}");
        }

        double volumenPromedio = totalVolumen / cajas.Count;

        Console.WriteLine($"Total de volumen de todas las cajas: {totalVolumen}");
        Console.WriteLine($"Volumen promedio de las cajas: {volumenPromedio}");
    }
}