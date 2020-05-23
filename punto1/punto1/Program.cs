using System;

namespace punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, inverso=0;
            string cadena;

            Console.WriteLine("ingrese un numero: ");
            cadena = Console.ReadLine();

            n = Convert.ToInt32(cadena);

            if (n <= 0)
            {
                Console.WriteLine("no se puede invertir numero: " + n);
            }
            else
            {
                while (n % 10 != 0)
                {
                    inverso = inverso * 10 + n%10;
                    n = n/10;
                }
                Console.WriteLine("numero invertido es: " + inverso);

            }


        }
    }
}
