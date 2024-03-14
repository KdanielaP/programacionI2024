using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio6
{
    internal class Desafio_6
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
