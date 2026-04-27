using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== LAB 12 =====");
            Console.WriteLine("1. Diagonales 5x5");
            Console.WriteLine("2. Pares e impares");
            Console.WriteLine("3. Notas");
            Console.WriteLine("4. Matriz simétrica");
            Console.WriteLine("5. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
            }

        } while (opcion != 5);
    }

    // =========================
    // EJERCICIO 1
    // =========================
    static void Ejercicio1()
    {
        int[,] m = new int[5, 5];
        Llenar(m);

        Console.WriteLine("Suma diagonal principal: " + SumaDiagonalPrincipal(m));
        Console.WriteLine("Suma diagonal secundaria: " + SumaDiagonalSecundaria(m));
    }

    static void Llenar(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write($"[{i},{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int SumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            suma += m[i, i];
        }
        return suma;
    }

    static int SumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        int n = m.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            suma += m[i, n - 1 - i];
        }
        return suma;
    }

    // =========================
    // EJERCICIO 2
    // =========================
    static void Ejercicio2()
    {
        int[,] m = new int[4, 6];
        Llenar(m);

        Console.WriteLine("Pares: " + ContarPares(m));
        Console.WriteLine("Impares: " + ContarImpares(m));
    }

    static int ContarPares(int[,] m)
    {
        int c = 0;
        foreach (int n in m)
        {
            if (n % 2 == 0)
                c++;
        }
        return c;
    }

    static int ContarImpares(int[,] m)
    {
        int c = 0;
        foreach (int n in m)
        {
            if (n % 2 != 0)
                c++;
        }
        return c;
    }

    // =========================
    // EJERCICIO 3
    // =========================
    static void Ejercicio3()
    {
        float[,] notas = new float[5, 4];
        IngresarNotas(notas);

        for (int i = 0; i < 5; i++)
        {
            float prom = Promedio(notas, i);
            Console.WriteLine($"Estudiante {i + 1}: {prom} - {(Aprueba(prom) ? "Aprobado" : "Reprobado")}");
        }
    }

    static void IngresarNotas(float[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write($"Nota estudiante {i + 1}: ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
        }
    }

    static float Promedio(float[,] m, int est)
    {
        float suma = 0;

        for (int j = 0; j < m.GetLength(1); j++)
        {
            suma += m[est, j];
        }

        return suma / m.GetLength(1);
    }

    static bool Aprueba(float prom)
    {
        return prom >= 61;
    }

    // =========================
    // EJERCICIO 4
    // =========================
    static void Ejercicio4()
    {
        int[,] m = new int[3, 3];
        Llenar(m);

        if (EsSimetrica(m))
            Console.WriteLine("La matriz es simétrica");
        else
            Console.WriteLine("No es simétrica");
    }

    static bool EsSimetrica(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (m[i, j] != m[j, i])
                    return false;
            }
        }
        return true;
    }
}