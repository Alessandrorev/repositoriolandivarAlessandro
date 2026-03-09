using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== LABORATORIO 07 =====");
        Console.WriteLine("1 - WHILE (Colores 1 al 20)");
        Console.WriteLine("2 - DO-WHILE (Divisores)");
        Console.WriteLine("3 - FOR (Fibonacci)");
        Console.WriteLine("4 - Ciclos Anidados (Tablas)");
        Console.Write("Seleccione opción: ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Ejercicio1();
                break;
            case "2":
                Ejercicio2();
                break;
            case "3":
                Ejercicio3();
                break;
            case "4":
                Ejercicio4();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        Console.ReadLine();
    }
    static void Ejercicio1()
    {
        Console.WriteLine("\n--- Ejercicio 1 ---");

        string nombre = "Tu Nombre";
        string carnet = "Tu Carnet";

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Carnet: " + carnet);

        int i = 1;

        while (i <= 20)
        {
            if (i % 2 == 0)
                Console.ForegroundColor = ConsoleColor.Cyan;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(i);

            i++; 
        }

        Console.ForegroundColor = ConsoleColor.White;
    }
    static void Ejercicio2()
    {
        Console.WriteLine("\n--- Ejercicio 2 ---");

        Console.Write("Ingrese número entero positivo: ");
        int numero = int.Parse(Console.ReadLine());

        int contador = 1;

        Console.WriteLine("Divisores:");

        do
        {
            if (numero % contador == 0)
            {
                Console.WriteLine(contador);
            }

            contador++;

        } while (contador <= numero);
    }
    static void Ejercicio3()
    {
        Console.WriteLine("\n--- Ejercicio 3 ---");

        Console.Write("Ingrese cantidad de términos: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int siguiente = a + b;
            a = b;
            b = siguiente;
        }
    }
    static void Ejercicio4()
    {
        Console.WriteLine("\n--- Tablas del 1 al 12 ---");

        for (int tabla = 1; tabla <= 12; tabla++)
        {
            Console.WriteLine("\nTabla del " + tabla);

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                int resultado = tabla * multiplicador;
                Console.WriteLine(tabla + " x " + multiplicador + " = " + resultado);
            }
        }
    }
}
