using System;

namespace Desafio
{
    internal class Caja
    {
    }
}
class Caja
{
    public double Largo { get; set; }
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Caja(double largo, double ancho, double alto)
    {
        Largo = largo;
        Ancho = ancho;
        Alto = alto;
    }

    public double CalcularVolumen()
    {
        return Largo * Ancho * Alto;
    }
}