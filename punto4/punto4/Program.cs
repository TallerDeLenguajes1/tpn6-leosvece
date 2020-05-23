using System;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1, cadena2;

            //1
            /* Console.WriteLine("ingrese una cadena de caracteres");
             cadena1 = Console.ReadLine();

             Console.WriteLine("algunas letras de la cadena son: " + cadena1[0] + ",  "+ cadena1[2] + ",  " + cadena1[4] + ",  ");
 //2
             Console.WriteLine("el tamaño de la cadena es: " + cadena1.Length);

 //3
             Console.WriteLine("ingrese la primera de caracteres");
             cadena1 = Console.ReadLine();

             Console.WriteLine("ingrese la segunda cadena de caracteres");
             cadena2 = Console.ReadLine();

             Console.WriteLine("las cadenas unidas:\n" + String.Concat(cadena1,cadena2));
  //4

             Console.WriteLine("ingrese una cadena de caracteres");
             cadena1 = Console.ReadLine();
             Console.WriteLine("una sub cadena de la cadena es: " + cadena1.Substring(0, 3));
//5
            
            calcular();*/

            //6
            /*         Console.WriteLine("ingrese una cadena de caracteres");
                       cadena1 = Console.ReadLine();
                       foreach (char c in cadena1)
                       {
                           Console.Write(c + " ");
                       }
           */
            //7

            /*
            Console.WriteLine("ingrese una cadena de caracteres");
            cadena1 = Console.ReadLine();
            Console.WriteLine("ingrese la palabra que busca:");
            cadena2 = Console.ReadLine();
            
            if (cadena1.Contains(cadena2))
            {
                Console.WriteLine("la palabra existe");

            }
            else
            {
                Console.WriteLine("la palabra no existe");

            }

            

            //8         
            Console.WriteLine("ingrese una cadena de caracteres");
            cadena1 = Console.ReadLine();
            Console.WriteLine("cadena en minuscula: " + cadena1.ToLower());
            Console.WriteLine("cadena en mayuscula: " + cadena1.ToUpper());*/

            //9
            /*
            Console.WriteLine("Ingrese la cadena a comparar: ");
            cadena1 = Console.ReadLine();
            Console.WriteLine("\nIngrese la caddena a comparar: ");
            cadena2 = Console.ReadLine();

            if (cadena1.CompareTo(cadena2) == 0)
            {
                Console.WriteLine("\nLas cadenas son iguales");
            }
            else
            {
                Console.WriteLine("\nLas cadenas son diferentes:");
            }*/

            //10
            /*
            Console.WriteLine("ingrese una cadena de caracteres separados por '.'");
            cadena1 = Console.ReadLine();
            string[] arreglo = cadena1.Split(".");

            for(int i =0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            */

            //11

            Console.WriteLine("escriba una operacion basica");
            cadena1 = Console.ReadLine();

            string[] arreglo = cadena1.Split("");

            int a = Convert.ToInt32(arreglo[0]);
            string operador = arreglo[1];
            int b = Convert.ToInt32(arreglo[2]);

            switch (operador)
            {
                case "+":
                   double resultado = a + b;
                    Console.WriteLine("la suma de" + a + " y" + b + "es: " + resultado);
                    break;
                case "-":
                    resultado = a - b;
                    double Console.WriteLine("la resta de" + a + " y" + b + "es: " + resultado); break;
                case "*":
                    resultado = a * b;
                    double Console.WriteLine("la multiplicacion de" + a + " y" + b + "es: " + resultado); break;
                case "/":
                    resultado = a / b;
                    double Console.WriteLine("la deivision de" + a + " y" + b + "es: " + resultado); break;
            }

       //si no hubiera echo la funcion tipo void podria reutilizar condigo, pero me dio vagancia al llegar aqui, perdon


        }

        public static void calcular()
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
                    Console.WriteLine("la suma de" + a + " y" + b + "es: " + resultado);
                    break;
                case "-":
                    resultado = a - b;
                    Console.WriteLine("la resta de" + a + " y" + b + "es: " + resultado); break;
                case "*":
                    resultado = a * b;
                    Console.WriteLine("la multiplicacion de" + a + " y" + b + "es: " + resultado); break;
                case "/":
                    resultado = a / b;
                    Console.WriteLine("la deivision de" + a + " y" + b + "es: " + resultado); break;
            }

        }
    }
}
