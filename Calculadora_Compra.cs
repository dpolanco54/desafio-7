using System;

class Program
{
    static void Main()
    {
        // 5 clientes, 5 compras cada uno
        double[,] compras = {
            {50, 20, 10, 5, 10},
            {200, 300, 100, 50, 150},
            {500, 200, 400, 100, 50},
            {20, 30, 10, 15, 5},
            {1000, 200, 50, 30, 20}
        };

        CalcularDescuentos(compras);
    }

    static void CalcularDescuentos(double[,] datos)
    {
        for (int i = 0; i < datos.GetLength(0); i++)
        {
            double total = 0;

            // Sumar compras del cliente (fila)
            for (int j = 0; j < datos.GetLength(1); j++)
            {
                total += datos[i, j];
            }

            double descuento = 0;

            // Aplicar reglas
            if (total >= 100 && total <= 1000)
            {
                descuento = total * 0.10;
            }
            else if (total > 1000)
            {
                descuento = total * 0.20;
            }

            double totalFinal = total - descuento;

            Console.WriteLine("Cliente " + (i + 1));
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + totalFinal);
            Console.WriteLine("-----------------------");
        }
    }
}