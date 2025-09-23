//Declara una variable global puntuacion. Cada vez que se llame al método GanarPuntos, la puntuación debe aumentar en 10 y mostrarse en pantalla.

using System;

class Program
{
    //variable global
    static int puntacion = 0;

    static void Main(string[] args)
    {
        {
            GanarPuntos();
            GanarPuntos();
            GanarPuntos();
            GanarPuntos();
            GanarPuntos();
        } 

    }
    static void GanarPuntos() // metodo que aumenta la puntacion
    {
        puntacion += 10;
        Console.WriteLine($"Tienes {puntacion} puntos ganados");
    }
}