using System;

class Program
{
    static void Main()
    {
        // =========================
        // VARIABLES
        // =========================
        double capital = 10000;
        double tasa = 0.05;
        double intereses;
        double abonos = 1500;

        // =========================
        // SIMULACIÓN DEL CRÉDITO
        // =========================
        for (int mes = 1; mes <= 8; mes++)
        {
            // Calcular intereses
            intereses = capital * tasa;

            // Actualizar capital
            capital = capital + intereses - abonos;

            // Mostrar información
            Console.WriteLine("Mes: " + mes);
            Console.WriteLine("Intereses: Q" + intereses);
            Console.WriteLine("Abono: Q" + abonos);
            Console.WriteLine("Capital restante: Q" + capital);

            Console.WriteLine("----------------------");
        }

        Console.WriteLine("Crédito finalizado.");
    }
}