using System;

class Program
{
    static void Main()
    {
        // =========================
        // MENÚ PRINCIPAL
        // =========================
        int opcion;

        do
        {
            Console.WriteLine("\n===== LABORATORIO 10 =====");
            Console.WriteLine("1. Sumar dígitos");
            Console.WriteLine("2. Ajustar saldo");
            Console.WriteLine("3. Convertir temperatura");
            Console.WriteLine("4. Sistema de puntos");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    EjecutarSumaDigitos();
                    break;

                case 2:
                    EjecutarAjusteSaldo();
                    break;

                case 3:
                    EjecutarConversionTemp();
                    break;

                case 4:
                    EjecutarSistemaPuntos();
                    break;

                case 5:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 5);
    }

    // =========================
    // EJECUCIONES (orden limpio)
    // =========================

    static void EjecutarSumaDigitos()
    {
        Console.Write("Ingrese número: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado: " + SumarDigitos(num));
    }

    static void EjecutarAjusteSaldo()
    {
        int saldo = 500;

        Console.WriteLine(AjustarSaldo(ref saldo, 200));
        Console.WriteLine("Saldo: " + saldo);

        Console.WriteLine(AjustarSaldo(ref saldo, 400));
        Console.WriteLine("Saldo: " + saldo);
    }

    static void EjecutarConversionTemp()
    {
        Console.Write("Ingrese Celsius: ");
        double c = double.Parse(Console.ReadLine());

        double f = 0;
        Console.WriteLine(ConvertirTemp(c, ref f));
    }

    static void EjecutarSistemaPuntos()
    {
        int puntos = 50;

        puntos = AgregarPuntos(ref puntos);
        Console.WriteLine("Puntos: " + puntos);

        puntos = QuitarPuntos(ref puntos);
        Console.WriteLine("Puntos: " + puntos);

        Console.WriteLine("Nivel: " + ObtenerNivel(puntos));
        Console.WriteLine("Estado: " + EvaluarEstado(puntos));
    }

    // =========================
    // FUNCIONES REALES
    // =========================

    static int SumarDigitos(int numero)
    {
        int suma = 0;

        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }

        return suma;
    }

    static string AjustarSaldo(ref int saldo, int retiro)
    {
        if (saldo >= retiro)
        {
            saldo -= retiro;
            return "Retiro exitoso";
        }
        else
        {
            return "Fondos insuficientes";
        }
    }

    static string ConvertirTemp(double celsius, ref double fahrenheit)
    {
        fahrenheit = (celsius * 9 / 5) + 32;
        return "Fahrenheit: " + fahrenheit;
    }

    static int AgregarPuntos(ref int puntos)
    {
        puntos += 10;

        if (puntos > 100)
            puntos = 100;

        return puntos;
    }

    static int QuitarPuntos(ref int puntos)
    {
        puntos -= 7;

        if (puntos < 0)
            puntos = 0;

        return puntos;
    }

    static string ObtenerNivel(int puntos)
    {
        if (puntos >= 80)
            return "Avanzado";
        else if (puntos >= 50)
            return "Intermedio";
        else
            return "Básico";
    }

    static string EvaluarEstado(int puntos)
    {
        if (puntos == 100)
            return "Excelente";
        else if (puntos >= 70)
            return "Aprobado";
        else if (puntos >= 1)
            return "Reprobado";
        else
            return "Sin puntos";
    }
}