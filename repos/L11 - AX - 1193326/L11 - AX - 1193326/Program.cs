using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== LAB 11 =====");
            Console.WriteLine("1. Palíndromos");
            Console.WriteLine("2. Traducción");
            Console.WriteLine("3. Calificaciones");
            Console.WriteLine("4. Planilla");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    EjecutarPalindromo();
                    break;

                case 2:
                    EjecutarTraduccion();
                    break;

                case 3:
                    EjecutarCalificaciones();
                    break;

                case 4:
                    EjecutarPlanilla();
                    break;
            }

        } while (opcion != 5);
    }

    // =========================
    // 1. PALÍNDROMO
    // =========================

    static void EjecutarPalindromo()
    {
        Console.Write("Ingrese palabra: ");
        string palabra = Console.ReadLine().ToLower();

        Console.WriteLine(EsPalindromo(palabra));
    }

    static bool EsPalindromo(string palabra)
    {
        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
                return false;
        }
        return true;
    }

    // =========================
    // 2. TRADUCCIÓN
    // =========================

    static void EjecutarTraduccion()
    {
        string[] esp = { "rojo", "azul", "amarillo", "blanco", "verde" };
        string[] eng = { "red", "blue", "yellow", "white", "green" };
        string[] ita = { "rosso", "blu", "giallo", "bianco", "verde" };

        Console.Write("Ingrese palabra en español: ");
        string palabra = Console.ReadLine().ToLower();

        int index = BuscarIndice(esp, palabra);

        if (index != -1)
        {
            Console.WriteLine($"{esp[index]}, {eng[index]}, {ita[index]}");
        }
        else
        {
            Console.WriteLine("La palabra no corresponde a la lección");
        }
    }

    static int BuscarIndice(string[] arr, string palabra)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == palabra)
                return i;
        }
        return -1;
    }

    // =========================
    // 3. CALIFICACIONES
    // =========================

    static void EjecutarCalificaciones()
    {
        int[] notas = GenerarNotas();

        int opcion;

        do
        {
            Console.WriteLine("\n1. Reporte");
            Console.WriteLine("2. Estadísticas");
            Console.WriteLine("3. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarNotas(notas);
                    break;

                case 2:
                    MostrarEstadisticas(notas);
                    break;
            }

        } while (opcion != 3);
    }

    static int[] GenerarNotas()
    {
        Random rand = new Random();
        int[] arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(50, 101);
        }

        return arr;
    }

    static void MostrarNotas(int[] notas)
    {
        foreach (int n in notas)
        {
            if (n <= 64)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (n <= 79)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(n + " ");
        }

        Console.ResetColor();
        Console.WriteLine();
    }

    static void MostrarEstadisticas(int[] notas)
    {
        int mayor = notas[0];
        int menor = notas[0];
        int suma = 0;

        foreach (int n in notas)
        {
            if (n > mayor) mayor = n;
            if (n < menor) menor = n;
            suma += n;
        }

        Console.WriteLine("Promedio: " + (suma / notas.Length));
        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
    }

    // =========================
    // 4. PLANILLA
    // =========================

    static void EjecutarPlanilla()
    {
        string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
        double[] salario = { 100, 125.50, 98.65, 125, 132.50, 102.50 };
        double[] horas = new double[6];

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Horas trabajadas por {nombres[i]}: ");
            horas[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nombres.Length; i++)
        {
            double pago = CalcularPago(horas[i], salario[i]);

            Console.WriteLine($"{nombres[i]} -> Q{pago}");
        }
    }

    static double CalcularPago(double horas, double salario)
    {
        if (horas <= 40)
        {
            return horas * salario;
        }
        else
        {
            double extra = horas - 40;
            return (40 * salario) + (extra * salario * 1.5);
        }
    }
}