using System;

class Program
{
    static void Main(string[] args)
    {
        CalcularPromedio();
    }

    static void CalcularPromedio()
    {
        // Variables locales
        double nota1, nota2, nota3, promedio;

        Console.Write("Ingrese la primera nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"\nEl promedio de las tres notas es: {promedio:F2}");
    }
}
