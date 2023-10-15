using System;

namespace Pracrica8
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\nMenu de opciones:");
                Console.WriteLine("1. Multiplicar numeros");
                Console.WriteLine("2. Restar numeros");
                Console.WriteLine("3. Cocatenear cadenas");
                Console.WriteLine("4. Salir");
                Console.Write("\nIngrese su opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese dos numeros para multiplicar:");

                            Console.Write("\nNumero 1: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nNumero 2: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nResultado de la multiplicacion (entero ): " + Multiplicar(num1, num2));

                            Console.WriteLine("\nIngrese dos numeros decimales para multiplicar:");

                            Console.Write("\nNumero 1: ");
                            double num1Double = Convert.ToDouble(Console.ReadLine());

                            Console.Write("\nNumero 2: ");
                            double num2Double = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\nResultado de la multiplicacion (decimal): " + Multiplicar(num1Double, num2Double));
                            break;

                        case 2:
                            Console.WriteLine("\nEl resultado es: " + RestarNumeros(20, 5, 3, 2));
                            break;

                        case 3:
                            Console.Write("\nIngrese su primer nombre: ");
                            string? cadena1 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su primer apellido: ");
                            string? cadena2 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese el separdor: ");
                            string? separador1 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenacion1 = ConcatenarCadenas(cadena1, cadena2, separador1);
                            Console.WriteLine($"\nResultado de la concatenacion: {resultadoConcatenacion1}");

                            Console.Write("\nIngrese su segundo nombre: ");
                            string? cadena3 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su segundo apellido: ");
                            string? cadena4 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su edad: ");
                            string? edad = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese el separdor: ");
                            string? separador2 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenacion2 = ConcatenarCadenas(cadena3, cadena4, edad, separador2);
                            Console.WriteLine($"\nResultado de la concatenacion: {resultadoConcatenacion2}");
                            break;

                        case 4:
                            Console.WriteLine("\nSaliendo del programa....");
                            break;
                        default:
                            Console.WriteLine("\nOPcion no valida. Intenta denuevo");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nOpcion no valida. Intente de nuevo.");
                }
            } while (opcion != 4);
        }//Fin de main

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }//Fin de primer multiplicar
        static double Multiplicar(double a, double b)
        {
            return a * b;
        }//Fin de segundo multiplicar

        static int RestarNumeros(params int[] numeros)
        {
            int resultado = numeros[0]; //Inicializamos el resultado con el primer numero

            for (int i = 1; i < numeros.Length; i++)
            {
                resultado -= numeros[i]; //Restamos los numeros uno por uno
            }

            return resultado;
        }//Fin de restarnumero

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? separador1)
        {
            return cadena1 + separador1 + cadena2;
        }//Fin de primerconcatenar

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? edad, string? separador1)
        {
            return cadena1 + separador1 + cadena2 + separador1 + edad;
        }//Fin de segundoconcatenar
    }
}
