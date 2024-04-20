using System;
using System;

public class OperacionesBasicas
{

    public static void main(String[] args)
    {

        sumar(10, 5);
        restar(10, 5);
        multiplicar(10, 5);
        dividir(10, 5);

        try
        {
            sumarValores();
        }
        catch (Exception e)
        {
            System.out.println("Error: " + e.getMessage());
        }
        finally
        {
            System.out.println("Operación finalizada");
        }
    }

    public static int sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int dividir(int num1, int num2)
    {
        return num1 / num2;
    }

    public static void sumarValores() throws Exception
    {
        Scanner scanner = new Scanner(System.in);

        try {
            System.out.print("Ingresa el primer valor: ");
    int valor1 = Integer.parseInt(scanner.nextLine());

    System.out.print("Ingresa el segundo valor: ");
    int valor2 = Integer.parseInt(scanner.nextLine());

    System.out.println("La suma de los valores es: " + (valor1 + valor2));

        } catch (NumberFormatException e) {
            throw new Exception("Valor introducido no es un número válido");
        } finally {
    scanner.close();
}
    }
}