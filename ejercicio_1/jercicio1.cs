//1.	Contador de accesos global
//Declara una variable global que almacene el número de veces que se ha ejecutado un método. 
//Cada vez que se llame al método, debe incrementar el contador y mostrarlo en pantalla.

using System;
namespace ContadorAccesosGlobal
{
    class Program
    {
        // Variable global para contar los accesos
        static int contadorAccesos = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Contador de accesos global al método.");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escriba la cantidad de veces que desea llamar al método:");
            int cantidadLlamadas = Convert.ToInt32(Console.ReadLine());
            if (cantidadLlamadas < 1)
            {
                Console.WriteLine("Por favor, ingrese un número válido mayor que 0.");
            }
            else
            {
                for (int i = 0; i < cantidadLlamadas; i++)
                {
                    MetodoConContador();
                }
            }
            
        }

        static void MetodoConContador()
        {
            // Incrementar el contador cada vez que se llama al método
            contadorAccesos++;
            // Mostrar el número de accesos en pantalla
            Console.WriteLine($"El método ha sido ejecutado {contadorAccesos} veces.");
        }
    }
}