//Simulacion de cajero Automatico

//Usar una variable global que represente el saldo de una cuenta bancaria 

//Metodo locales para

//Depositar dinero

//retirar dinero ( validando que no exceda el saldo )

//consultar saldo

using System;

class Program
{
    static double saldo = 1000.00; // Variable global para el saldo (usamos double para manejar decimales)

    static void Main(string[] args)
    {
        while (true) // Bucle para mantener el menú activo
        {
            Console.Clear();
            Console.WriteLine("-------Bienvenido a BAC--------");
            Console.WriteLine("\n¿Qué deseas hacer?");
            Console.WriteLine("1. Depositar saldo");
            Console.WriteLine("2. Retirar saldo");
            Console.WriteLine("3. Consultar saldo");
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
                    Depositar();
                    break;
                case 2:
                    Retirar();
                    break;
                case 3:
                    ConsultarSaldo();
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar el cajero BAC. ¡Hasta pronto!");
                    return; // Sale del programa
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void Depositar()
    {
        Console.Write("\nIngrese el monto a depositar: $");
        if (double.TryParse(Console.ReadLine(), out double monto) && monto > 0)
        {
            saldo += monto;
            Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${saldo:F2}");
        }
        else
        {
            Console.WriteLine("Monto inválido. Debe ser mayor a 0.");
        }
    }

    static void Retirar()
    {
        Console.Write("\nIngrese el monto a retirar: $");
        if (double.TryParse(Console.ReadLine(), out double monto) && monto > 0)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${saldo:F2}");
            }
            else
            {
                Console.WriteLine("Estas pobre bro!!!");
            }
        }
        else
        {
            Console.WriteLine("Monto inválido. Debe ser mayor a 0.");
        }
    }

    static void ConsultarSaldo()
    {
        Console.WriteLine($"\nSu saldo actual es: ${saldo:F2}");
    }
}