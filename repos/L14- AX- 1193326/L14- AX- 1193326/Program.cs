using System;

// =========================
// CLASE CUENTABANCARIA
// =========================
class CuentaBancaria
{
    public string titular;
    public string numeroCuenta;
    public double saldo;

    // Constructor
    public CuentaBancaria(string t, string n, double s)
    {
        titular = t;
        numeroCuenta = n;
        saldo = s;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Titular: " + titular);
        Console.WriteLine("Cuenta: " + numeroCuenta);
        Console.WriteLine("Saldo: Q" + saldo);
    }

    public void Depositar(double monto)
    {
        saldo += monto;
    }

    public void Retirar(double monto)
    {
        if (saldo >= monto)
        {
            saldo -= monto;
            Console.WriteLine("Retiro realizado.");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes.");
        }
    }
}

// =========================
// CLASE PRODUCTO
// =========================
class Producto
{
    public string nombre;
    public double precio;
    public int cantidad;

    public Producto(string n, double p, int c)
    {
        nombre = n;
        precio = p;
        cantidad = c;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: Q" + precio);
        Console.WriteLine("Cantidad: " + cantidad);
    }

    public void Vender(int cantidadVendida)
    {
        if (cantidad >= cantidadVendida)
        {
            cantidad -= cantidadVendida;
            Console.WriteLine("Venta realizada.");
        }
        else
        {
            Console.WriteLine("No hay suficiente stock.");
        }
    }

    public void Reabastecer(int cantidadNueva)
    {
        cantidad += cantidadNueva;
    }
}

// =========================
// CLASE ESTUDIANTE
// =========================
class Estudiante
{
    public string nombre;
    public int edad;
    public string grado;
    public double[] notas;

    public Estudiante(string n, int e, string g, double[] no)
    {
        nombre = n;
        edad = e;
        grado = g;
        notas = no;
    }

    public double CalcularPromedio()
    {
        double suma = 0;

        foreach (double n in notas)
        {
            suma += n;
        }

        return suma / notas.Length;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Grado: " + grado);

        Console.Write("Notas: ");

        foreach (double n in notas)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Promedio: " + CalcularPromedio());
    }

    public bool Aprobar()
    {
        return CalcularPromedio() >= 61;
    }

    public void AgregarNota(double nuevaNota)
    {
        double[] nuevo = new double[notas.Length + 1];

        for (int i = 0; i < notas.Length; i++)
        {
            nuevo[i] = notas[i];
        }

        nuevo[nuevo.Length - 1] = nuevaNota;

        notas = nuevo;
    }
}

// =========================
// MAIN
// =========================
class Program
{
    static void Main()
    {
        // =========================
        // EJERCICIO 1
        // =========================
        CuentaBancaria c1 = new CuentaBancaria("Juan", "001", 1000);
        CuentaBancaria c2 = new CuentaBancaria("Maria", "002", 500);

        Console.WriteLine("===== CUENTAS =====");

        c1.MostrarInformacion();
        Console.WriteLine();

        Console.WriteLine("Depositando Q200...");
        c1.Depositar(200);

        Console.WriteLine("Retirando Q300...");
        c1.Retirar(300);

        c1.MostrarInformacion();

        Console.WriteLine();

        c2.MostrarInformacion();

        // =========================
        // EJERCICIO 2
        // =========================
        Producto p1 = new Producto("Laptop", 5000, 10);
        Producto p2 = new Producto("Mouse", 150, 20);

        Console.WriteLine("\n===== PRODUCTOS =====");

        p1.MostrarInformacion();

        Console.WriteLine("Vendiendo 3...");
        p1.Vender(3);

        Console.WriteLine("Reabasteciendo 5...");
        p1.Reabastecer(5);

        p1.MostrarInformacion();

        Console.WriteLine();

        p2.MostrarInformacion();

        // =========================
        // EJERCICIO 3
        // =========================
        double[] notas1 = { 70, 80, 90 };
        double[] notas2 = { 50, 60, 55 };

        Estudiante e1 = new Estudiante("Carlos", 16, "4to", notas1);
        Estudiante e2 = new Estudiante("Ana", 17, "5to", notas2);

        Console.WriteLine("\n===== ESTUDIANTES =====");

        e1.MostrarInformacion();
        Console.WriteLine("¿Aprobó? " + e1.Aprobar());

        Console.WriteLine();

        e2.MostrarInformacion();
        Console.WriteLine("¿Aprobó? " + e2.Aprobar());

        Console.WriteLine("\nAgregando nueva nota a Ana...");
        e2.AgregarNota(80);

        e2.MostrarInformacion();
        Console.WriteLine("¿Aprobó ahora? " + e2.Aprobar());
    }
}