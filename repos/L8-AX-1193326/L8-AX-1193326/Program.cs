using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== LABORATORIO 08 =====");
        Console.WriteLine("1 - Estadísticas de 20 números");
        Console.WriteLine("2 - Par / Siete / ParSiete");
        Console.WriteLine("3 - Tienda (10 clientes)");
        Console.WriteLine("4 - Menú de números");
        Console.WriteLine("5 - Triángulo de asteriscos");

        Console.Write("Seleccione opción: ");
        int opcion = int.Parse(Console.ReadLine());

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
            case 5:
                Ejercicio5();
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }

    static void Ejercicio1()
    {
        int numero;
        int mayor = int.MinValue;
        int menor = int.MaxValue;
        int suma = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.Write("Ingrese número " + i + ": ");
            numero = int.Parse(Console.ReadLine());

            if (numero > mayor)
                mayor = numero;

            if (numero < menor)
                menor = numero;

            suma += numero;
        }

        double promedio = (double)suma / 20;

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Promedio: " + promedio);
    }

    static void Ejercicio2()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 && i % 7 == 0)
                Console.WriteLine(i + " ParSiete");
            else if (i % 2 == 0)
                Console.WriteLine(i + " Par");
            else if (i % 7 == 0)
                Console.WriteLine(i + " Siete");
            else
                Console.WriteLine(i);
        }
    }

    static void Ejercicio3()
    {
        double compra;
        double totalVentas = 0;
        int clientesConDescuento = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Monto cliente " + i + ": ");
            compra = double.Parse(Console.ReadLine());

            double descuento = 0;

            if (compra > 700)
            {
                descuento = 0.12;
                clientesConDescuento++;
            }
            else if (compra > 300)
            {
                descuento = 0.05;
                clientesConDescuento++;
            }

            double total = compra - (compra * descuento);

            Console.WriteLine("Total pagado: $" + total);

            totalVentas += total;
        }

        Console.WriteLine("Clientes con descuento: " + clientesConDescuento);
        Console.WriteLine("Total ventas del día: $" + totalVentas);
    }

    static void Ejercicio4()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - Mostrar desde N hasta 1");
        Console.WriteLine("2 - Múltiplos de 3");
        Console.WriteLine("3 - Múltiplos de 5");

        Console.Write("Seleccione opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                for (int i = n; i >= 1; i--)
                    Console.WriteLine(i);
                break;

            case 2:
                for (int i = 1; i <= n; i++)
                    if (i % 3 == 0)
                        Console.WriteLine(i);
                break;

            case 3:
                for (int i = 1; i <= n; i++)
                    if (i % 5 == 0)
                        Console.WriteLine(i);
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }

    static void Ejercicio5()
    {
        Console.Write("Ingrese número de filas: ");
        int filas = int.Parse(Console.ReadLine());

        for (int i = 1; i <= filas; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}