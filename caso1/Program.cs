using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string entrada;

            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Tiene una entrada válida? Escriba si o no:");
            entrada = Console.ReadLine();

            if (edad >= 0)
            {
                if (edad >= 18 && entrada == "si")
                {
                    Console.WriteLine("Puede ingresar a la actividad.");
                }
                else
                {
                    Console.WriteLine("No puede ingresar a la actividad.");
                }
            }
            else
            {
                Console.WriteLine("La edad ingresada no es válida.");
            }

            Console.ReadLine();
        }
    }
}
