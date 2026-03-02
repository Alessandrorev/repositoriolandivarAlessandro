using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== LABORATORIO 06 =====");
        Console.WriteLine("1 - Conversión de Temperaturas");
        Console.WriteLine("2 - Descuentos en Tienda");
        Console.WriteLine("3 - Estacionamiento");
        Console.WriteLine("4 - Evaluación de Empleados");
        Console.Write("Seleccione una opción: ");

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
    }
    static void Ejercicio1()
    {
        Console.WriteLine("\n--- Conversión de Temperaturas ---");
        Console.WriteLine("1 - Celsius a Fahrenheit");
        Console.WriteLine("2 - Fahrenheit a Celsius");
        Console.WriteLine("3 - Celsius a Kelvin");
        Console.Write("Opción: ");

        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese temperatura: ");
        double temp = double.Parse(Console.ReadLine());

        double resultado;

        switch (opcion)
        {
            case 1:
                resultado = (temp * 9 / 5) + 32;
                Console.WriteLine("Resultado: " + resultado + " °F");
                break;

            case 2:
                resultado = (temp - 32) * 5 / 9;
                Console.WriteLine("Resultado: " + resultado + " °C");
                break;

            case 3:
                resultado = temp + 273.15;
                Console.WriteLine("Resultado: " + resultado + " K");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    // =========================================
    // EJERCICIO 2 - DESCUENTOS TIENDA
    static void Ejercicio2()
    {
        Console.WriteLine("\n--- Descuentos Tienda ---");

        Console.Write("Tipo de cliente (1: Regular, 2: VIP): ");
        int tipo = int.Parse(Console.ReadLine());

        Console.Write("Cantidad de unidades: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Precio por unidad: ");
        double precio = double.Parse(Console.ReadLine());

        double descuento = 0;

        // Prioridad mayorista
        if (cantidad > 100)
        {
            descuento = 0.15;
        }
        else
        {
            switch (tipo)
            {
                case 1:
                    descuento = 0.05;
                    break;
                case 2:
                    descuento = 0.10;
                    break;
                default:
                    Console.WriteLine("Tipo inválido.");
                    return;
            }
        }

        double total = cantidad * precio;
        double totalConDescuento = total - (total * descuento);

        Console.WriteLine("Total sin descuento: $" + total);
        Console.WriteLine("Descuento aplicado: " + (descuento * 100) + "%");
        Console.WriteLine("Total a pagar: $" + totalConDescuento);
    }

    // =========================================
    // EJERCICIO 3 - ESTACIONAMIENTO
    static void Ejercicio3()
    {
        Console.WriteLine("\n--- Estacionamiento ---");

        Console.Write("Ingrese horas: ");
        int horas = int.Parse(Console.ReadLine());

        double tarifa;

        if (horas < 2)
        {
            tarifa = 5;
        }
        else if (horas <= 5)
        {
            tarifa = 4;
        }
        else
        {
            tarifa = 3;
        }

        double total = horas * tarifa;

        Console.WriteLine("Tarifa por hora: $" + tarifa);
        Console.WriteLine("Total a pagar: $" + total);
    }

    // =========================================
    // EJERCICIO 4 - EVALUACIÓN EMPLEADOS
    static void Ejercicio4()
    {
        Console.WriteLine("\n--- Evaluación Empleados ---");

        Console.Write("Ingrese puntuación (0.0, 0.4, 0.6 o más): ");
        double puntuacion = double.Parse(Console.ReadLine());

        string nivel;
        double dinero;

        if (puntuacion == 0.0)
        {
            nivel = "Inaceptable";
        }
        else if (puntuacion == 0.4)
        {
            nivel = "Aceptable";
        }
        else if (puntuacion >= 0.6)
        {
            nivel = "Meritorio";
        }
        else
        {
            Console.WriteLine("Puntuación inválida.");
            return;
        }

        dinero = 2400 * puntuacion;

        Console.WriteLine("Nivel: " + nivel);
        Console.WriteLine("Dinero a recibir: €" + dinero);
    }
}