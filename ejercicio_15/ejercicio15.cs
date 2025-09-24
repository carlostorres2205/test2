using System;

class Calculadora
{
    static double ultimoResultado = 0;

    static void Main()
    {
        Console.WriteLine("Calcula Cientifica Básica");

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicación");
            Console.WriteLine("4.División");
            Console.WriteLine("5.Potencia");
            Console.WriteLine("6.Raíz Cuadrada");
            Console.WriteLine("7.Salir");
            Console.WriteLine("*************************");

            Console.WriteLine("Opción:");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Sumar();
                    break;
                case "2":
                    Restar();
                    break;
                case "3":
                    Multiplicar();
                    break;
                case "4":
                    Dividir();
                    break;
                case "5":
                    Potencia();
                    break;
                case "6":
                    RaizCuadrada();
                    break;
                case "7":
                    Salir();
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("*************************");
                Console.WriteLine($"Último resultado: {ultimoResultado}");
            }
        }

        Console.WriteLine("Gracias por usar la calculadora :)");
    }

    static void Sumar()
    {
        Console.WriteLine("Ingresa el primer número:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número:");
        double b = double.Parse(Console.ReadLine());

        ultimoResultado = a + b;
    }

    static void Restar()
    {
        Console.WriteLine("Ingresa el primer número:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número:");
        double b = double.Parse(Console.ReadLine());

        ultimoResultado = a - b;
    }

    static void Multiplicar()
    {
        Console.WriteLine("Ingresa el primer número:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número:");
        double b = double.Parse(Console.ReadLine());

        ultimoResultado = a * b;
    }

    static void Dividir()
    {
        Console.WriteLine("Ingresa el primer número:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número:");
        double b = double.Parse(Console.ReadLine());

        if (b != 0)
        {
            ultimoResultado = a / b;
        }
        else
        {
            Console.WriteLine("No se puede dividir entre 0");
        }
    }

    static void Potencia()
    {
        Console.WriteLine("Ingresa la base:");
        double baseNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el exponente:");
        double exponente = double.Parse(Console.ReadLine());

        ultimoResultado = Math.Pow(baseNum, exponente);
    }

    static void RaizCuadrada()
    {
        Console.WriteLine("Ingresa el número:");
        double num = double.Parse(Console.ReadLine());

        if (num >= 0)
        {
            ultimoResultado = Math.Sqrt(num);
        }
        else
        {
            Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo");
            ultimoResultado = 0;
        }
    }

    static void Salir()
    {
        Console.WriteLine("Saliendo del programa...");
    }
}