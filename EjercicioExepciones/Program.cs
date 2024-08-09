using EjercicioExepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear una clase llamada Operaciones, debe crear métodos para las operaciones básicas de 2 parámetros
             * (sumar, restar, multiplicar, dividir)
             * Deberá crear un menú donde las opciones sean las operaciones básicas y una opción para salir.
             * El programa debe ser cíclico
             * (Mientras no se presione el número de opción de salir, el programa sigue corriendo)
             * Aplicar excepciones segun sea el caso
             */

            Operacion operacion = new Operacion();

            double numeroUno;
            double numeroDos;
            int opcion = 0;

            do
            {
                Menu();
                Console.WriteLine();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Suma");
                        Console.WriteLine();
                        try
                        {
                            Console.WriteLine("Ingrese un número: ");
                            numeroUno = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese otro número: ");
                            numeroDos = double.Parse(Console.ReadLine());
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString());
                            continue;
                        }
                        Console.WriteLine($"Resultado: {operacion.Suma(numeroUno, numeroDos)}");
                        break;

                    case 2:
                        Console.WriteLine("Resta");
                        Console.WriteLine();
                        try
                        {
                            Console.WriteLine("Ingrese un número");
                            numeroUno = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese otro número");
                            numeroDos = double.Parse(Console.ReadLine());
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString()); ;
                            continue;
                        }
                        Console.WriteLine($"Resultado: {operacion.Resta(numeroUno, numeroDos)}");
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Multiplicación");
                        try
                        {
                            Console.WriteLine("Ingrese un número");
                            numeroUno = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese otro número");
                            numeroDos = double.Parse(Console.ReadLine());
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString());
                            continue;
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Resultado: {operacion.Multiplicacion(numeroUno, numeroDos)}");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("División");
                        Console.WriteLine();
                        try
                        {
                            Console.WriteLine("Ingrese un número");
                            numeroUno = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese otro número");
                            numeroDos = double.Parse(Console.ReadLine());

                            if (numeroDos == 0)
                            {
                                Console.WriteLine("Error: No se puede dividir por cero.");
                            }
                            else
                            {
                                Console.WriteLine($"Resultado: {operacion.Division(numeroUno, numeroDos)}");
                            }
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"Error:   { ex.ToString()}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, por favor elige una opción del 1 al 5.");
                        break;
                }
            } while (opcion != 5);

        }

        public static void Menu()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1.suma" +
                "\r\n2.Resta" +
                "\r\n3.Multiplicacion" +
                "\r\n4.Division" +
                "\r\n5.Salir");  
        }
    }
}
