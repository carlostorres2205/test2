using System;
using System.Globalization;

class programaFecha
{
    static void Main()
    {
        // Pedir datos
        Console.WriteLine("Ingresa el dia:");
        int dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el mes:");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el año:");
        int año = Convert.ToInt32(Console.ReadLine());

        //Valicaciones por funciones
        bool mesValido = EsMesValido(mes);
        bool añoBisiesto = EsBisiesto(año);
        bool diaValido = EsDiaValido(dia, mes, año);

        if (mesValido && diaValido)
        {
            Console.WriteLine($"La fehca {dia:D2}/{mes:D2}/{año} es válida");
            if (añoBisiesto)
            {
                Console.WriteLine($"El año {año} es bisiesto");
            }
            else
            {
                Console.WriteLine($"El año {año} no es bisiesto");
            }
        }
        else
        {
            Console.WriteLine($"La fecha {dia:D2}/{mes:D2}/{año} no es válida");
        }

        Console.WriteLine("Fin del programa");
    }

    // Fuciones
    static bool EsMesValido(int mes)
    {
        return mes >= 1 && mes <= 12; // Verifica si el número del es está entre 1 y 12
    }

    static bool EsBisiesto(int año)
    {

        return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0); // Determina si un año es bisiesto si es divisible por 4, pero no por 100, a menos que tambien sea divisible por 400
    }

    static bool EsDiaValido(int dia, int mes, int año)
    {
        int[] diasPorMes = { 31, EsBisiesto(año) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // Arreglo con la cantidad de dias que tiene cada mes
                                                                                                      // Si el año es bisiesto toma el 29 si no es asi toma el 28 

        if (mes < 1 || mes > 12) // Si el mes está fuera del rango 1 y 12 se retorna false
            return false;

        return dia >= 1 && dia <= diasPorMes[mes - 1]; // Verifica si el día entre 1 y el máaximo permitido para ese mes y ese año
    }
}