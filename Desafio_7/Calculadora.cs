using System;

public class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero");
            return 0;
        }
    }
}

public class CalculadoraCientifica : Calculadora
{
    public double Potencia(double num, double exponente)
    {
        return Math.Pow(num, exponente);
    }

    public double Raiz(double num)
    {
        return Math.Sqrt(num);
    }

    public double Modulo(double num1, double num2)
    {
        return num1 % num2;
    }

    public double Logaritmo(double num)
    {
        return Math.Log10(num);
    }
}