//2.	Área de un rectángulo con variables locales
//Crea un método que pida la base y altura de un rectángulo, use variables locales para calcular el área y la imprima en pantalla.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de área de un rectángulo");

        CalcularArea();

    }
    static void CalcularArea()
    {
        // Variables locales
        double baseRectangulo;
        double alturaRectangulo;
        double area;

        // Solicitar base y altura al usuario
        Console.Write("Ingrese la base del rectángulo: ");
        baseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del rectángulo: ");
        alturaRectangulo = Convert.ToDouble(Console.ReadLine());

        // Calcular el área
        area = baseRectangulo * alturaRectangulo;

        // Imprimir el área en pantalla
        Console.WriteLine($"El área del rectángulo es: {area} unidades cuadradas");
    }
}