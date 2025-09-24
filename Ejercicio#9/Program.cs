using System;

class Program
{
    // Método que calcula el perímetro usando solo variables locales
    static double CalcularPerimetro(double radio)
    {
        double pi = Math.PI; // funcion que ya existe en c#
        double perimetro = 2 * pi * radio;
        return perimetro;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double resultado = CalcularPerimetro(radio);

        Console.WriteLine("El perímetro del círculo es: " + resultado);
    }
}
