using System;

class Program
{
    // Variable global simulada
    static bool sesionIniciada = false;

    static void Main()
    {
        string contraseñaCorrecta = "1234";

        Console.Write("Ingrese la contraseña: ");
        string input = Console.ReadLine();

        if (input == contraseñaCorrecta)
        {
            sesionIniciada = true;
            Console.WriteLine("Inicio de sesión exitoso.");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta.");
        }

        // Verificamos el estado de la sesión
        Console.WriteLine("Sesión iniciada?: " + sesionIniciada);
    }
}