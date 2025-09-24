class Program
{
    static List<double> notas = new List<double>(); // Lista global para almacenar las notas

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------Gestión de Notas de Estudiantes--------");
            Console.WriteLine("\n¿Qué deseas hacer?");
            Console.WriteLine("1. Agregar una nota");
            Console.WriteLine("2. Calcular el promedio");
            Console.WriteLine("3. Mostrar nota más alta y más baja");
            Console.WriteLine("4. Salir");
            Console.Write("\nSeleccione una opción (1-4): ");

            // Validar que la entrada sea un número
            if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    AgregarNota();
                    break;
                case 2:
                    CalcularPromedio();
                    break;
                case 3:
                    MostrarNotasExtremas();
                    break;
                case 4:
                    Console.WriteLine("Bye por el momento. ");
                    return; 
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void AgregarNota()
    {
        Console.Write("\nIngrese la nota (0-100): ");
        if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 100)
        {
            notas.Add(nota);
            Console.WriteLine($"Nota {nota:F2} agregada correctamente.");
        }
        else
        {
            Console.WriteLine("Error: La nota debe ser un número entre 0 y 100.");
        }
    }

    static void CalcularPromedio()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("\nNo hay notas registradas.");
            return;
        }

        double suma = 0; // Variable local para la suma
        foreach (double nota in notas)
        {
            suma += nota;
        }
        double promedio = suma / notas.Count; // Variable local para el promedio
        Console.WriteLine($"\nEl promedio de las notas es: {promedio:F2}");
    }

    static void MostrarNotasExtremas()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("\nNo hay notas registradas.");
            return;
        }

        double notaMaxima = notas[0]; // Variable local para la nota máxima
        double notaMinima = notas[0]; // Variable local para la nota mínima

        foreach (double nota in notas)
        {
            if (nota > notaMaxima)
                notaMaxima = nota;
            if (nota < notaMinima)
                notaMinima = nota;
        }

        Console.WriteLine($"\nNota más alta: {notaMaxima:F2}");
        Console.WriteLine($"Nota más baja: {notaMinima:F2}");
    }
}
