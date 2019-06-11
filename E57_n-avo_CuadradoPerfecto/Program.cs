using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E57_n_avo_CuadradoPerfecto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion;
            int? resultado = null;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Programa que calcula el n-avo cuadrado perfecto");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Introduce un número:");

                if (Int32.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
                {
                    resultado = CalcularNCuadradoPerfecto(numero);
                    if (resultado.HasValue)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Resultado = {0}", CalcularNCuadradoPerfecto(numero));
                        Console.WriteLine("Resultado = {0} \"Math.Pow()\"", Math.Pow(numero, 2));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error no se pudo obtener el resultado");
                    }                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error al introducir número");
                }

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nn : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);

            } while (!salir);
        }

        public static int? CalcularNCuadradoPerfecto(int numero)
        {
            if (numero >= 0)
                return numero *= numero;
            return null;
        }
    }
}
