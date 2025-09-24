//4.Suma acumulada con variable global
//Declara una variable global sumaTotal. 
//Cada vez que el usuario ingrese un número (en un método), se debe sumar al acumulado y mostrar el total actualizado.

using System;

class Program
{
    // Variable global para la suma total
    static double sumaTotal = 0;

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== Suma Acumulada ===");
            Console.Write("Ingrese un número (o 'salir' para terminar): ");
            string? entrada = Console.ReadLine();

            if (entrada?.ToLower() == "salir")
            {
                continuar = false;
                Console.WriteLine($"Suma total: {sumaTotal}");
            }
            else
            {
                if (double.TryParse(entrada, out double numero))
                {
                    AgregarNumero(numero);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }
        }
    }

    static void AgregarNumero(double numero)
    {
        sumaTotal += numero;
        Console.WriteLine($"Número agregado: {numero}");
        Console.WriteLine($"Suma total acumulada: {sumaTotal}");
    }
}