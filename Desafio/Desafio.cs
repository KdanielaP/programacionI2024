using System;

namespace Desafio
{
    internal class Desafio
    {
    }
}

public class Rectangulo
{
    // Campos
    private double alto;
    private double largo;

    // Propiedades
    public double Alto
    {
        get { return alto; }
        set
        {
            if (value > 0)
            {
                alto = value;
            }
            else
            {
                throw new ArgumentException("El valor del alto debe ser mayor que cero.");
            }
        }
    }

    public double Largo
    {
        get { return largo; }
        set
        {
            if (value > 0)
            {
                largo = value;
            }
            else
            {
                throw new ArgumentException("El valor del largo debe ser mayor que cero.");
            }
        }
    }

    public double SuperficieFrontal
    {
        get { return Alto * Largo; }
    }

    // Constructores
    public Rectangulo(double alto, double largo)
    {
        Alto = alto;
        Largo = largo;
    }

}
