using System;

class CajeroAutomatico
{
    // Variable global que representa el saldo
    static decimal saldo = 1000; // saldo inicial

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Cajero Automático ---");
            Console.WriteLine("1. Depositar dinero");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Consultar saldo");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Depositar();
                    break;
                case 2:
                    Retirar();
                    break;
                case 3:
                    Consultar();
                    break;
                case 4:
                    Console.WriteLine(" Gracias por usar el cajero.");
                    break;
                default:
                    Console.WriteLine(" Opción no válida.");
                    break;
            }
        } while (opcion != 4);
    }

    static void Depositar()
    {
        Console.Write("Ingrese la cantidad a depositar: ");
        decimal deposito = Convert.ToDecimal(Console.ReadLine()); // variable local
        saldo += deposito;
        Console.WriteLine($"✔ Depósito exitoso. Nuevo saldo: {saldo:C}");
    }

    static void Retirar()
    {
        Console.Write("Ingrese la cantidad a retirar: ");
        decimal retiro = Convert.ToDecimal(Console.ReadLine()); // variable local
        if (retiro <= saldo)
        {
            saldo -= retiro;
            Console.WriteLine($" Retiro exitoso. Nuevo saldo: {saldo:C}");
        }
        else
        {
            Console.WriteLine(" Fondos insuficientes.");
        }
    }

    static void Consultar()
    {
        Console.WriteLine($" Su saldo actual es: {saldo:C}");
    }
}
