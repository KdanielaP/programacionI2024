using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientes
{
    internal class Clientes
    {
    }
}

namespace CalculoTotalCompras
{
    class Program
    {
        static void Main()
        {
            int[,] comprasClientes = new int[5, 5];

            // Ingresar los montos de las compras de los clientes
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese los montos de las últimas 5 compras del cliente {i + 1}:");
                for (int j = 0; j < 5; j++)
                {
                    comprasClientes[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calcular el total de compras y aplicar descuento
            for (int i = 0; i < 5; i++)
            {
                int totalCompra = 0;
                for (int j = 0; j < 5; j++)
                {
                    totalCompra += comprasClientes[i, j];
                }

                double descuento;
                if (totalCompra <= 100)
                {
                    descuento = 0;
                }
                else if (totalCompra > 100 && totalCompra <= 500)
                {
                    descuento = totalCompra * 0.05; // 5% de descuento
                }
                else
                {
                    descuento = totalCompra * 0.1; // 10% de descuento
                }

                Console.WriteLine($"El cliente {i + 1} tiene un total de compras de: {totalCompra} y su descuento es de {descuento}");
            }
        }
    }
}