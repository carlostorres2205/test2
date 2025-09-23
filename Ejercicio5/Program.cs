//5. Edad de una persona con variables locales
//Diseña un método que use variables locales para leer el año de nacimiento de una persona y calcule su edad. 
//La edad no debe almacenarse de forma global.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al programa que calcula tu edad.");

        CalcularEdad();
    }

    static void CalcularEdad()
    {
        int anioActual = DateTime.Now.Year; //Variable local

        Console.Write("Ingrese su año de nacimiento: ");
        int anioNacimiento = Convert.ToInt32(Console.ReadLine()); 

        //Validación básica del año de nacimiento
        while (anioNacimiento < 1900 || anioNacimiento > DateTime.Now.Year)
        {
            Console.Write("Año inválido. Por favor, ingrese un año de nacimiento válido: ");
            anioNacimiento = Convert.ToInt32(Console.ReadLine());
        }

        int edad = anioActual - anioNacimiento; // Variable local

        Console.WriteLine($"Su edad es: {edad} años.");
    }
}
