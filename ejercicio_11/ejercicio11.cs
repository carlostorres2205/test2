using System;

class Program
{
    // Variable global para almacenar el inventario total
    static int inventario = 0;

    static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("\n=== Sistema de Inventario ===");
            Console.WriteLine("1. Agregar productos");
            Console.WriteLine("2. Retirar productos");
            Console.WriteLine("3. Consultar inventario");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarProductos();
                    break;
                case 2:
                    RetirarProductos();
                    break;
                case 3:
                    ConsultarInventario();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 4);
    }

    // Método para agregar productos
    static void AgregarProductos()
    {
        Console.Write("¿Cuántos productos deseas agregar?: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        inventario += cantidad;
        Console.WriteLine($"Se agregaron {cantidad} productos. Inventario actual: {inventario}");
    }

    // Método para retirar productos
    static void RetirarProductos()
    {
        Console.Write("¿Cuántos productos deseas retirar?: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad <= inventario)
        {
            inventario -= cantidad;
            Console.WriteLine($"Se retiraron {cantidad} productos. Inventario actual: {inventario}");
        }
        else
        {
            Console.WriteLine("No hay suficientes productos en inventario para retirar esa cantidad.");
        }
    }

    // Método para consultar inventario
    static void ConsultarInventario()
    {
        Console.WriteLine($"Inventario actual: {inventario} productos.");
    }
}