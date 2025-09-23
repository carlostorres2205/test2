using System;

class Program
{
    // Variable global para almacenar intentos
    static int intentos = 0;

    static void Main(string[] args)
    {
        // Genera un número secreto aleatorio entre 1 y 10
        Random random = new Random();
        int numeroSecreto = random.Next(1, 11); // 1-10
        int numeroUsuario = 0;

        Console.WriteLine("Juego de Adivinar el Número");
        Console.WriteLine("Intenta adivinar el número secreto (entre 1 y 10).");

        while (numeroUsuario != numeroSecreto)
        {
            Console.Write("\nIngresa tu número: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numeroUsuario))
            {
                // Validamos si está dentro del rango permitido
                if (numeroUsuario < 1 || numeroUsuario > 10)
                {
                    Console.WriteLine(" El número debe estar entre 1 y 10. Intenta de nuevo.");
                    continue; // vuelve a pedir número SIN contar intento
                }

                intentos++; // Incrementa la variable global
                Console.WriteLine($"Intento #{intentos}: ingresaste {numeroUsuario}");

                if (numeroUsuario == numeroSecreto)
                {
                    Console.WriteLine($"\n ¡Felicidades! Adivinaste el número en {intentos} intentos.");
                }
                else
                {
                    Console.WriteLine(" No es el número correcto, inténtalo de nuevo.");
                }
            }
            else
            {
                Console.WriteLine(" Por favor, ingresa un número válido.");
            }
        }
    }
}
