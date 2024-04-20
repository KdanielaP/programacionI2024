namespace sesion7
{


    internal class program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 1, 2, 3 };
            int[] arreglo2 = new int[10];
            int[] arreglo3 = new int[4] { 1, 2, 4, 3 };
            // gyardar valores en arreglo 
            arreglo2[0] = 1;
            Console.WriteLine(arreglo2[0]);
           
            for (int i = 0; i < arreglo2.Length; i++)
            {
                arreglo2[i] = i + 1;

                Console.WriteLine(arreglo2[i]);

                int contador = 0;
                while (contador < arreglo2.Length)
                {
                 
                    Console.WriteLine(arreglo2[contador]);
                    contador++;
                }
            }

        }
    }

}
