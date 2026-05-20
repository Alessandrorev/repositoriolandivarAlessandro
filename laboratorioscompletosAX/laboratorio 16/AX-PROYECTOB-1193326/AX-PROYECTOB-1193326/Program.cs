using System;

class Parcela
{
    public string planta;
    public int mesesRestantes;
    public int ingreso;
    public bool ocupada;
}

class Program
{
    static Parcela[,] granja;

    static int dinero;
    static int empleados;
    static int sueldo;
    static int meses;

    static int trigo = 0;
    static int tomate = 0;
    static int repollo = 0;

    static int ingresosTotales = 0;
    static int gastosSemillas = 0;
    static int manoObra = 0;

    static void Main()
    {
        Console.Write("Dinero inicial: ");
        dinero = int.Parse(Console.ReadLine());

        Console.Write("Número empleados: ");
        empleados = int.Parse(Console.ReadLine());

        Console.Write("Sueldo mensual: ");
        sueldo = int.Parse(Console.ReadLine());

        Console.Write("Meses a simular: ");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        granja = new Parcela[filas, columnas];

        InicializarParcelas();

        Menu();
    }

    // =========================
    // INICIALIZAR MATRIZ
    // =========================
    static void InicializarParcelas()
    {
        for (int i = 0; i < granja.GetLength(0); i++)
        {
            for (int j = 0; j < granja.GetLength(1); j++)
            {
                granja[i, j] = new Parcela();

                granja[i, j].planta = "Vacía";
                granja[i, j].ocupada = false;
            }
        }
    }

    // =========================
    // MENÚ
    // =========================
    static void Menu()
    {
        int opcion;

        while (meses > 0 && dinero > 0)
        {
            Console.WriteLine("\n===== GRANJA =====");
            Console.WriteLine("Dinero: Q" + dinero);
            Console.WriteLine("Meses restantes: " + meses);

            Console.WriteLine("1. Comprar semillas");
            Console.WriteLine("2. Sembrar");
            Console.WriteLine("3. Consultar parcelas");
            Console.WriteLine("4. Avanzar mes");
            Console.WriteLine("5. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ComprarSemillas();
                    break;

                case 2:
                    Sembrar();
                    break;

                case 3:
                    MostrarParcelas();
                    break;

                case 4:
                    AvanzarMes();
                    break;

                case 5:
                    ReporteFinal();
                    return;
            }
        }

        ReporteFinal();
    }

    // =========================
    // COMPRAR
    // =========================
    static void ComprarSemillas()
    {
        Console.WriteLine("1. Trigo Q100");
        Console.WriteLine("2. Tomate Q250");
        Console.WriteLine("3. Repollo Q180");

        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                if (dinero >= 100)
                {
                    trigo++;
                    dinero -= 100;
                    gastosSemillas += 100;
                }
                break;

            case 2:
                if (dinero >= 250)
                {
                    tomate++;
                    dinero -= 250;
                    gastosSemillas += 250;
                }
                break;

            case 3:
                if (dinero >= 180)
                {
                    repollo++;
                    dinero -= 180;
                    gastosSemillas += 180;
                }
                break;
        }
    }

    // =========================
    // SEMBRAR
    // =========================
    static void Sembrar()
    {
        Console.Write("Fila: ");
        int f = int.Parse(Console.ReadLine());

        Console.Write("Columna: ");
        int c = int.Parse(Console.ReadLine());

        if (!granja[f, c].ocupada)
        {
            Console.WriteLine("1. Trigo");
            Console.WriteLine("2. Tomate");
            Console.WriteLine("3. Repollo");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    if (trigo > 0)
                    {
                        granja[f, c].planta = "Trigo";
                        granja[f, c].mesesRestantes = 1;
                        granja[f, c].ingreso = 130;
                        granja[f, c].ocupada = true;

                        trigo--;
                    }
                    break;

                case 2:
                    if (tomate > 0)
                    {
                        granja[f, c].planta = "Tomate";
                        granja[f, c].mesesRestantes = 3;
                        granja[f, c].ingreso = 450;
                        granja[f, c].ocupada = true;

                        tomate--;
                    }
                    break;

                case 3:
                    if (repollo > 0)
                    {
                        granja[f, c].planta = "Repollo";
                        granja[f, c].mesesRestantes = 2;
                        granja[f, c].ingreso = 280;
                        granja[f, c].ocupada = true;

                        repollo--;
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Parcela ocupada.");
        }
    }

    // =========================
    // MOSTRAR MATRIZ
    // =========================
    static void MostrarParcelas()
    {
        for (int i = 0; i < granja.GetLength(0); i++)
        {
            for (int j = 0; j < granja.GetLength(1); j++)
            {
                if (granja[i, j].ocupada)
                    Console.Write("[X]");
                else
                    Console.Write("[ ]");
            }

            Console.WriteLine();
        }
    }

    // =========================
    // AVANZAR MES
    // =========================
    static void AvanzarMes()
    {
        meses--;

        int pago = empleados * sueldo;

        dinero -= pago;
        manoObra += pago;

        for (int i = 0; i < granja.GetLength(0); i++)
        {
            for (int j = 0; j < granja.GetLength(1); j++)
            {
                if (granja[i, j].ocupada)
                {
                    granja[i, j].mesesRestantes--;

                    if (granja[i, j].mesesRestantes == 0)
                    {
                        Console.WriteLine("Se cosechó " + granja[i, j].planta);

                        dinero += granja[i, j].ingreso;
                        ingresosTotales += granja[i, j].ingreso;

                        granja[i, j].ocupada = false;
                        granja[i, j].planta = "Vacía";
                    }
                }
            }
        }
    }

    // =========================
    // REPORTE
    // =========================
    static void ReporteFinal()
    {
        Console.WriteLine("\n===== REPORTE =====");

        Console.WriteLine("Ingresos: Q" + ingresosTotales);
        Console.WriteLine("Gastos semillas: Q" + gastosSemillas);
        Console.WriteLine("Mano de obra: Q" + manoObra);
        Console.WriteLine("Dinero final: Q" + dinero);
    }
}