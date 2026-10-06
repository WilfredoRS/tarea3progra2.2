using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3progra2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            {
                Console.WriteLine("--- CASO 4: Acceso a una actividad ---");
                Console.Write("Ingrese la edad de la persona: ");
                if (int.TryParse(Console.ReadLine(), out int edad))
                {
                    if (edad > 0 && edad <= 120)
                    {
                        Console.Write("¿Tiene entrada válida? (S para Sí / N para No): ");
                        string respuestaEntrada = Console.ReadLine().Trim().ToUpper();

                        bool tieneEntrada = (respuestaEntrada == "S" || respuestaEntrada == "SI");

                        if (edad >= 18 && tieneEntrada)
                        {
                            Console.WriteLine("\n¡Acceso permitido! Puede ingresar a la actividad.");
                        }
                        else
                        {
                            Console.WriteLine("\nAcceso denegado. Motivo:");
                            if (edad < 18)
                            {
                                Console.WriteLine("- La persona es menor de edad (debe tener al menos 18 años).");
                            }
                            if (!tieneEntrada)
                            {
                                Console.WriteLine("- La persona no cuenta con una entrada válida.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Por favor ingrese una edad real (entre 1 y 120).");
                    }
                }
                else
                {
                    Console.WriteLine(" Debe ingresar un número entero válido para la edad.");
                }
            }
        }
    }
}