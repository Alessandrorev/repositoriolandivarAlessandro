using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el nombre del curso: ");
            string curso = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Lab de Pensamiento Computacional");
            Console.WriteLine(nombre + ", vas muy bien en el curso " + curso + ".");
            Console.WriteLine("Nunca dejes de practicar.");
            Console.WriteLine();
            Console.WriteLine("Hoy es un buen día para seguir aprendiendo programación.");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");

            Console.ReadKey();
        }
    }
}