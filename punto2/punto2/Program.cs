using System;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float resultado;
            string c, operador;

            Console.WriteLine("ingrese la operacion siguiendo el siguiente orden: numero, enter operador, enter numero");
            c = Console.ReadLine();
            a = Convert.ToInt32(c);
            operador = Console.ReadLine();
            c = Console.ReadLine();
            b = Convert.ToInt32(c);

            switch (operador)
            {
                case "+":
                    resultado = a + b;
                    Console.WriteLine(resultado);
                    break;
                case "-":
                    resultado = a - b;
                    Console.WriteLine(resultado);
                    break;
                case "*":
                    resultado = a * b;
                    Console.WriteLine(resultado);
                    break;
                case "/":
                    resultado = a / b;
                    Console.WriteLine(resultado);
                    break;
            }

        }
     
    }
}
