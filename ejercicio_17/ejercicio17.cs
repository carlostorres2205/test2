using System;

class TiendaEnLinea
{
    // Variable global que guarda el total del carrito
    static double carritoTotal = 0.0;

    // Método para agregar un producto (sumar precio al total)
    static void AgregarProducto(double precio)
    {
        carritoTotal += precio;
        Console.WriteLine($" Producto agregado: ${precio}. Total actual: ${carritoTotal}");
    }

    // Método para eliminar un producto (restar precio del total)
    static void EliminarProducto(double precio)
    {
        if (precio > carritoTotal)
        {
            Console.WriteLine(" No puedes eliminar más de lo que hay en el carrito.");
        }
        else
        {
            carritoTotal -= precio;
            Console.WriteLine($" Producto eliminado: ${precio}. Total actual: ${carritoTotal}");
        }
    }

    // Método para consultar el total actual
    static void ConsultarTotal()
    {
        Console.WriteLine($" El total actual de la compra es: ${carritoTotal}");
    }

    // consola principal 
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n=== Simulador de Tienda en Línea ===");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Consultar total");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el precio del producto a agregar: ");
                    double precioAgregar = Convert.ToDouble(Console.ReadLine());
                    AgregarProducto(precioAgregar);
                    break;

                case 2:
                    Console.Write("Ingrese el precio del producto a eliminar: ");
                    double precioEliminar = Convert.ToDouble(Console.ReadLine());
                    EliminarProducto(precioEliminar);
                    break;

                case 3:
                    ConsultarTotal();
                    break;

                case 4:
                    Console.WriteLine(" Gracias por usar la tienda en línea.");
                    break;

                default:
                    Console.WriteLine(" Opción inválida, intenta de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }
}