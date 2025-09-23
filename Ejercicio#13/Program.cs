using System;

class juegoAdivinanza
{
    static int numeroSecreto; // Variable global para el num secreto
    static int intentos = 0; // Contador global de intentos

    static void Main()
    {
        Console.WriteLine("Bienvenido al juego de adivinanza!!");
        Console.WriteLine("He elegido un número entre 1 y 20");

        Random rand = new Random(); // Creamos una instancia de la calse Random rand, que se usa para generar un numero aleatorio
        numeroSecreto = rand.Next(1, 21); // Usamos el metodo Next de rand para obtener un número entero aleatorio y lo guardamos en numeroSecreto

        bool adivinado = false;
        while (!adivinado)
        {
            int intento = pedirIntento();

            adivinado = evaluarIntento(intento);
        }

        Console.WriteLine($"Felicidades adivinaste el número en {intentos} intentos");
        Console.WriteLine("Gracias por jugar");
    }

    static int pedirIntento()
    {
        Console.WriteLine("Por favor, ingresa tu número para adivinar");
        int intento = 0;
        while (!int.TryParse(Console.ReadLine(), out intento))
        {
            Console.WriteLine("Entrada inválida, debes ingresar un número entero");
            Console.WriteLine("Introduce tu intento");
        }
        return intento;
    }

    static bool evaluarIntento(int intento)
    {
        intentos++;

        if (intentos == numeroSecreto)
        {
            Console.WriteLine("Correcto");
            return true;
        }
        else
        {
            Console.WriteLine("Incorrecto, intenta otra vez");
            return false;
        }
    }
}