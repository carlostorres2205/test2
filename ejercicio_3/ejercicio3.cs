//3.Conversor de temperatura con variable global
//Declara una variable global que indique la escala de conversión (ejemplo: Celsius a Fahrenheit). 
//Haz un método que use esa variable para realizar la conversión.

using System;

class Program
{
    // Variable global para la escala de conversión
    static string? escalaConversion;

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== Conversor de temperatura ===");
            Console.WriteLine("Seleccione la escala de conversión:");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine("4. Kelvin a Celsius");
            Console.WriteLine("5. Fahrenheit a Kelvin");
            Console.WriteLine("6. Kelvin a Fahrenheit");
            Console.WriteLine("7. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
                escalaConversion = "Celsius a Fahrenheit";
            else if (opcion == 2)
                escalaConversion = "Fahrenheit a Celsius";
            else if (opcion == 3)
                escalaConversion = "Celsius a Kelvin";
            else if (opcion == 4)
                escalaConversion = "Kelvin a Celsius";
            else if (opcion == 5)
                escalaConversion = "Fahrenheit a Kelvin";
            else if (opcion == 6)
                escalaConversion = "Kelvin a Fahrenheit";
            else if (opcion == 7)
            {
                Console.WriteLine("Saliendo del programa.");
                break; // rompe el while y termina el programa
            }
            else
            {
                Console.WriteLine("Opción no válida.");
                continue; // vuelve a mostrar el menú
            }

            ConvertirTemperatura();

            Console.WriteLine("\n¿Desea hacer otra conversión? (s/n): ");
            string? respuesta = Console.ReadLine().ToLower();

            if (respuesta != "s")
            {
                continuar = false;
                Console.WriteLine("Gracias por usar el conversor de temperaturas.");
            }
        }
    }

    static void ConvertirTemperatura()
    {
        double temperaturaOriginal;
        double temperaturaConvertida;

        Console.Write("Ingrese la temperatura a convertir: ");
        temperaturaOriginal = Convert.ToDouble(Console.ReadLine());

        // Validación según la escala de origen
        if ((escalaConversion.Contains("Celsius") && temperaturaOriginal < -273.15) ||
            (escalaConversion.Contains("Fahrenheit") && temperaturaOriginal < -459.67) ||
            (escalaConversion.Contains("Kelvin") && temperaturaOriginal < 0))
        {
            Console.WriteLine("Error: La temperatura ingresada está por debajo del cero absoluto.");
            return; // no continúa la conversión
        }

        // Realiza la conversión según la escala seleccionada
        if (escalaConversion == "Celsius a Fahrenheit")
        {
            temperaturaConvertida = Math.Round((temperaturaOriginal * 9 / 5) + 32, 2);
            Console.WriteLine($"{temperaturaOriginal} °C son {temperaturaConvertida} °F");
        }
        else if (escalaConversion == "Fahrenheit a Celsius")
        {
            temperaturaConvertida = Math.Round((temperaturaOriginal - 32) * 5 / 9, 2);
            Console.WriteLine($"{temperaturaOriginal} °F son {temperaturaConvertida} °C");
        }
        else if (escalaConversion == "Celsius a Kelvin")
        {
            temperaturaConvertida = Math.Round(temperaturaOriginal + 273.15, 2);
            Console.WriteLine($"{temperaturaOriginal} °C son {temperaturaConvertida} K");
        }
        else if (escalaConversion == "Kelvin a Celsius")
        {
            temperaturaConvertida = temperaturaOriginal - 273.15;
            Console.WriteLine($"{temperaturaOriginal} K son {temperaturaConvertida} °C");
        }
        else if (escalaConversion == "Fahrenheit a Kelvin")
        {
            temperaturaConvertida = (temperaturaOriginal - 32) * 5 / 9 + 273.15;
            Console.WriteLine($"{temperaturaOriginal} °F son {temperaturaConvertida} K");
        }
        else if (escalaConversion == "Kelvin a Fahrenheit")
        {
            temperaturaConvertida = (temperaturaOriginal - 273.15) * 9 / 5 + 32;
            Console.WriteLine($"{temperaturaOriginal} K son {temperaturaConvertida} °F");
        }
        else
        {
            Console.WriteLine("Escala de conversión no válida.");
        }
    }
}