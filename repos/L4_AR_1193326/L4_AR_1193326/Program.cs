using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== EJERCICIO 1: PERFIL DEL PERSONAJE =====");

        string nombrePersonaje = "Wilson";
        int nivel = 25;
        float puntosVida = 345.75f;
        bool esJefe = true;

        Console.WriteLine("Nombre: " + nombrePersonaje);
        Console.WriteLine("Nivel: " + nivel);
        Console.WriteLine("Puntos de Vida: " + puntosVida);
        Console.WriteLine("¿Es jefe?: " + esJefe);

        Console.WriteLine("\n===== EJERCICIO 2: CONVERSIÓN IMPLÍCITA =====");

        int numeroEntero = 1500;
        long numeroLargo = numeroEntero;      // Implícita
        double numeroDecimal = numeroLargo;   // Implícita

        Console.WriteLine("Valor final en double: " + numeroDecimal);

        Console.WriteLine("\n===== EJERCICIO 3: CASTING EXPLÍCITO =====");

        double precioExacto = 45.89;
        int precioRedondeado = (int)precioExacto;

        Console.WriteLine("Precio exacto: " + precioExacto);
        Console.WriteLine("Precio convertido a entero: " + precioRedondeado);

        Console.WriteLine("\n===== EJERCICIO 4: PARSE =====");

        Console.Write("Ingrese un número: ");
        string entradaUsuario = Console.ReadLine();

        int numeroParseado = int.Parse(entradaUsuario);
        int resultado = numeroParseado + 5;

        Console.WriteLine("Resultado (numero + 5): " + resultado);

        Console.WriteLine("\n===== EJERCICIO 5: CONVERT =====");

        string valorBooleano = "true";
        bool convertidoBool = Convert.ToBoolean(valorBooleano);

        string valorDecimal = "25.5";
        double convertidoDouble = Convert.ToDouble(valorDecimal);

        Console.WriteLine("Boolean convertido: " + convertidoBool);
        Console.WriteLine("Double convertido: " + convertidoDouble);

        Console.WriteLine("\n===== EJERCICIO 6: TOSTRING =====");

        double pi = 3.14159265;
        string piTexto = pi.ToString();
        string piDosDecimales = pi.ToString("F2");

        Console.WriteLine("Pi completo: " + piTexto);
        Console.WriteLine("Pi con 2 decimales: " + piDosDecimales);

        Console.WriteLine("\n===== EJERCICIO 7: CALCULADORA DE IVA =====");

        Console.Write("Ingrese el precio del producto: ");
        string precioTexto = Console.ReadLine();

        double precio = Convert.ToDouble(precioTexto);
        double iva = precio * 0.21;
        double total = precio + iva;

        int totalEntero = (int)total;

        Console.WriteLine("El total a pagar es: " + totalEntero);

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}