using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== LABORATORIO 05 =====");
        Console.WriteLine("1 - Positivo / Negativo / Cero");
        Console.WriteLine("2 - Año Bisiesto");
        Console.WriteLine("3 - Boleto de Ornato");
        Console.WriteLine("4 - Máquina de Parqueo");
        Console.Write("Seleccione opción: ");

        string opcion = Console.ReadLine();

        if (opcion == "1")
            Ejercicio1();
        else if (opcion == "2")
            Ejercicio2();
        else if (opcion == "3")
            Ejercicio3();
        else if (opcion == "4")
            Ejercicio4();
        else
            Console.WriteLine("Opción inválida");
    }
    static void Ejercicio1()
    {
        Console.Write("Ingrese número: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Es positivo");
        else if (num < 0)
            Console.WriteLine("Es negativo");
        else
            Console.WriteLine("Es cero");
    }
    static void Ejercicio2()
    {
        Console.Write("Ingrese año: ");
        int año = int.Parse(Console.ReadLine());

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            Console.WriteLine("Es bisiesto");
        else
            Console.WriteLine("No es bisiesto");
    }
    static void Ejercicio3()
    {
        Console.Write("Ingreso mensual: ");
        double ingreso = double.Parse(Console.ReadLine());

        Console.Write("¿Tiene multa? (true/false): ");
        bool multa = bool.Parse(Console.ReadLine());

        double pago;

        if (ingreso < 500)
            pago = 5;
        else if (ingreso < 1500)
            pago = 15;
        else
            pago = 50;

        if (multa)
            pago += 10;

        Console.WriteLine("Pago total: Q" + pago);
    }
    static void Ejercicio4()
    {
        Console.Write("Horas estacionado: ");
        int horas = int.Parse(Console.ReadLine());

        int total = horas * 10;
        Console.WriteLine("Total a pagar: Q" + total);

        Console.Write("Monto ingresado: ");
        int pago = int.Parse(Console.ReadLine());

        if (pago < total)
        {
            Console.WriteLine("Fondos insuficientes");
            return;
        }
        else if (pago == total)
        {
            Console.WriteLine("Pago exacto");
            return;
        }

        int cambio = pago - total;
        Console.WriteLine("Cambio: Q" + cambio);

        int q100 = cambio / 100;
        cambio %= 100;

        int q50 = cambio / 50;
        cambio %= 50;

        int q20 = cambio / 20;
        cambio %= 20;

        int q10 = cambio / 10;
        cambio %= 10;

        int q5 = cambio / 5;
        cambio %= 5;

        int q1 = cambio;

        Console.WriteLine("Q100: " + q100);
        Console.WriteLine("Q50: " + q50);
        Console.WriteLine("Q20: " + q20);
        Console.WriteLine("Q10: " + q10);
        Console.WriteLine("Q5: " + q5);
        Console.WriteLine("Q1: " + q1);
    }
}