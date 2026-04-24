using System;

class Program
{
    static void Main()
    {
        char[,] tablero = new char[3, 3];
        char jugador = 'X';
        int fila, columna;
        bool juegoTerminado = false;

        // Inicializar tablero
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i, j] = '-';
            }
        }

        while (!juegoTerminado)
        {
            Console.Clear();
            MostrarTablero(tablero);

            Console.WriteLine("Turno del jugador: " + jugador);
            Console.Write("Fila (0-2): ");
            fila = int.Parse(Console.ReadLine());

            Console.Write("Columna (0-2): ");
            columna = int.Parse(Console.ReadLine());

            // Validar si la posición está libre
            if (tablero[fila, columna] == '-')
            {
                tablero[fila, columna] = jugador;

                if (HayGanador(tablero, jugador))
                {
                    Console.Clear();
                    MostrarTablero(tablero);
                    Console.WriteLine("¡Ganó el jugador " + jugador + "!");
                    juegoTerminado = true;
                }
                else if (TableroLleno(tablero))
                {
                    Console.Clear();
                    MostrarTablero(tablero);
                    Console.WriteLine("¡Empate!");
                    juegoTerminado = true;
                }
                else
                {
                    // Cambiar jugador
                    jugador = (jugador == 'X') ? 'O' : 'X';
                }
            }
            else
            {
                Console.WriteLine("Esa posición ya está ocupada.");
                Console.ReadKey();
            }
        }
    }

    static void MostrarTablero(char[,] tablero)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool HayGanador(char[,] t, char jugador)
    {
        // Filas y columnas
        for (int i = 0; i < 3; i++)
        {
            if (t[i, 0] == jugador && t[i, 1] == jugador && t[i, 2] == jugador)
                return true;

            if (t[0, i] == jugador && t[1, i] == jugador && t[2, i] == jugador)
                return true;
        }

        // Diagonales
        if (t[0, 0] == jugador && t[1, 1] == jugador && t[2, 2] == jugador)
            return true;

        if (t[0, 2] == jugador && t[1, 1] == jugador && t[2, 0] == jugador)
            return true;

        return false;
    }

    static bool TableroLleno(char[,] t)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (t[i, j] == '-')
                    return false;
            }
        }
        return true;
    }
}