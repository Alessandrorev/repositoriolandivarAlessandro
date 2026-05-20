using System;

// =========================
// CLASE PERSONA
// =========================
class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}

// =========================
// CLASE VEHICULO
// =========================
class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}

// =========================
// CLASE PRODUCTO
// =========================
class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;
}

// =========================
// CLASE MASCOTA
// =========================
class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;
}

// =========================
// PROGRAMA PRINCIPAL
// =========================
class Program
{
    static void Main()
    {
        // =========================
        // EJERCICIO 1: PERSONA
        // =========================
        Persona p = new Persona();

        p.nombre = "Juan";
        p.edad = 20;
        p.altura = 1.75;
        p.estudiante = true;

        Console.WriteLine("=== PERSONA ===");
        Console.WriteLine(p.nombre);
        Console.WriteLine(p.edad);
        Console.WriteLine(p.altura);
        Console.WriteLine(p.estudiante);

        // =========================
        // EJERCICIO 2: VEHICULO
        // =========================
        Vehiculo v = new Vehiculo();

        v.marca = "Toyota";
        v.modelo = "Corolla";
        v.anio = 2020;
        v.color = "Rojo";
        v.placa = "P123ABC";

        Console.WriteLine("\n=== VEHICULO ===");
        Console.WriteLine(v.marca);
        Console.WriteLine(v.modelo);
        Console.WriteLine(v.anio);
        Console.WriteLine(v.color);
        Console.WriteLine(v.placa);

        // =========================
        // EJERCICIO 3: PRODUCTO
        // =========================
        Producto prod1 = new Producto();
        Producto prod2 = new Producto();

        prod1.codigo = "001";
        prod1.nombre = "Laptop";
        prod1.precio = 5000;
        prod1.stock = 10;
        prod1.disponible = true;

        prod2.codigo = "002";
        prod2.nombre = "Mouse";
        prod2.precio = 150;
        prod2.stock = 25;
        prod2.disponible = true;

        Console.WriteLine("\n=== PRODUCTOS ===");

        Console.WriteLine("\nProducto 1:");
        Console.WriteLine(prod1.codigo);
        Console.WriteLine(prod1.nombre);
        Console.WriteLine(prod1.precio);
        Console.WriteLine(prod1.stock);
        Console.WriteLine(prod1.disponible);

        Console.WriteLine("\nProducto 2:");
        Console.WriteLine(prod2.codigo);
        Console.WriteLine(prod2.nombre);
        Console.WriteLine(prod2.precio);
        Console.WriteLine(prod2.stock);
        Console.WriteLine(prod2.disponible);

        // =========================
        // EJERCICIO 4: MASCOTA
        // =========================
        Mascota m = new Mascota();

        m.nombre = "Firulais";
        m.especie = "Perro";
        m.edad = 3;
        m.peso = 12.5;
        m.vacunado = true;

        Console.WriteLine("\n=== MASCOTA ===");
        Console.WriteLine(m.nombre);
        Console.WriteLine(m.especie);
        Console.WriteLine(m.edad);
        Console.WriteLine(m.peso);
        Console.WriteLine(m.vacunado);
    }
}