using System;

namespace punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado,a, c, d;
            string b;

            Console.WriteLine("ingrese un nomero");
            b = Console.ReadLine();
            a = Convert.ToDouble(b);

            Console.WriteLine("ingrese la opcion que busca: \n1)valorabsoluto \n2)cuadrado \n3)raiz cuadrada " +
                "\n4)seno \n5)coseno \n6)entero de un flotante");

            b = Console.ReadLine();
       

            switch (b)
            {
                case "1":
                    resultado = Math.Abs(a);
                    Console.WriteLine(resultado);
                    break;
                case "2":
                    resultado = Math.Pow(a, 2);
                    Console.WriteLine(resultado);
                    break;
                case "3":

                    resultado = Math.Sqrt(a);
                    Console.WriteLine(resultado);
                    break;
                case "4":
                    resultado = Math.Sin(a);
                    Console.WriteLine(resultado);
                    break;
                case "5":
                    resultado = Math.Cos(a) ;
                    Console.WriteLine(resultado);
                    break;
                case "6":
                    resultado = Math.Round(a);
                    Console.WriteLine(resultado);
                    break;
            }

            Console.WriteLine("ingrese un dos numeros");
            b = Console.ReadLine();
            c = Convert.ToDouble(b);
            b = Console.ReadLine();
            d = Convert.ToDouble(b);

            Console.WriteLine("el maximo entre los numeros:" + Math.Max(c,d));
            Console.WriteLine("el minimo entre los numeros:" + Math.Min(c,d));

        }

    }
}
