using System;

namespace Tarea05_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            int[] tabla = new int[11];
            Console.WriteLine("Tabla del {0}: ", numero);
            for (int i=0; i < tabla.Length; i++)
            {
                tabla[i] = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, tabla[i]);
            }

            Console.ReadKey();
        }
    }
}
