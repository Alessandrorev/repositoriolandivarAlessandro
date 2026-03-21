using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("EJERCICIO 1");
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        ContarCaracteres(palabra);

        Console.WriteLine("\nEJERCICIO 2");
        int A = 4;
        int B = 13;

        Console.WriteLine("Antes:");
        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);

        Intercambiar(ref A, ref B);

        Console.WriteLine("Después:");
        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);

        Console.WriteLine("\nEJERCICIO 3");

        double precio = 48.50;
        double descuento = 0.15;

        Console.WriteLine("Precio antes: Q" + precio);

        AplicarDescuento(descuento, ref precio);

        Console.WriteLine("Precio después: Q" + precio);

        Console.WriteLine("\nEJERCICIO 4");

        int salud = 10;

        mostrarSalud(salud);

        recibirDanio(ref salud);
        mostrarSalud(salud);

        curar(ref salud);
        mostrarSalud(salud);

        calificarDesempeno(salud);
    }


    static void ContarCaracteres(string texto)
    {
        Console.WriteLine("Cantidad de caracteres: " + texto.Length);
    }


    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void AplicarDescuento(double porcentaje, ref double precio)
    {
        precio = precio - (precio * porcentaje);
    }

    static void recibirDanio(ref int salud)
    {
        salud -= 5;
        if (salud < 0)
            salud = 0;
    }

    static void curar(ref int salud)
    {
        salud += 3;
        if (salud > 15)
            salud = 15;
    }

    static void mostrarSalud(int salud)
    {
        if (salud >= 11)
            Console.ForegroundColor = ConsoleColor.Green;
        else if (salud >= 6)
            Console.ForegroundColor = ConsoleColor.Yellow;
        else
            Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Salud: " + salud);
        Console.ResetColor();
    }

    static void calificarDesempeno(int salud)
    {
        Console.Write("Calificación: ");

        if (salud == 15)
            Console.WriteLine("S");
        else if (salud >= 11)
            Console.WriteLine("A");
        else if (salud >= 6)
            Console.WriteLine("B");
        else
            Console.WriteLine("C");
    }
}