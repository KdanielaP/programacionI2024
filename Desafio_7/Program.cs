class Program
{
    static void Main()
    {
        CalculadoraCientifica calcCientifica = new CalculadoraCientifica();

        Console.WriteLine("Ingrese dos números enteros para realizar operaciones básicas: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("La suma es: " + calcCientifica.Sumar(num1, num2));
        Console.WriteLine("La resta es: " + calcCientifica.Restar(num1, num2));
        Console.WriteLine("La multiplicación es: " + calcCientifica.Multiplicar(num1, num2));
        Console.WriteLine("La división es: " + calcCientifica.Dividir(num1, num2));

        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Ingrese un número para operaciones científicas: ");
        double num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("El cuadrado es: " + calcCientifica.Potencia(num, 2));
        Console.WriteLine("La raíz cuadrada es: " + calcCientifica.Raiz(num));
        Console.WriteLine("El módulo es: " + calcCientifica.Modulo(num, 2));
        Console.WriteLine("El logaritmo en base 10 es: " + calcCientifica.Logaritmo(num));
    }
}