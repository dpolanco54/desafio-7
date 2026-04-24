using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tareas = new List<string>();
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarTareas(tareas);
                    break;

                case 2:
                    AgregarTarea(tareas);
                    break;

                case 3:
                    EliminarTarea(tareas);
                    break;
            }

        } while (opcion != 4);
    }

    static void MostrarTareas(List<string> lista)
    {
        Console.Clear();
        Console.WriteLine("=== LISTA DE TAREAS ===");

        if (lista.Count == 0)
        {
            Console.WriteLine("No hay tareas.");
        }
        else
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + lista[i]);
            }
        }

        Console.ReadKey();
    }

    static void AgregarTarea(List<string> lista)
    {
        Console.Clear();
        Console.Write("Ingrese la tarea: ");
        string tarea = Console.ReadLine();

        lista.Add(tarea);
        Console.WriteLine("Tarea agregada.");
        Console.ReadKey();
    }

    static void EliminarTarea(List<string> lista)
    {
        Console.Clear();
        MostrarTareas(lista);

        if (lista.Count > 0)
        {
            Console.Write("Ingrese el número de la tarea a eliminar: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 && num <= lista.Count)
            {
                lista.RemoveAt(num - 1);
                Console.WriteLine("Tarea eliminada.");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        Console.ReadKey();
    }
}