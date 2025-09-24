class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------Validador de Contraseñas Seguras--------");
            Console.WriteLine("\nRequisitos de la contraseña:");
            Console.WriteLine("- Mínimo 8 caracteres");
            Console.WriteLine("- Al menos una letra mayúscula");
            Console.WriteLine("- Al menos una letra minúscula");
            Console.WriteLine("- Al menos un número");
            Console.WriteLine("- Al menos un carácter especial (!@#$%^&*)");
            Console.Write("\nIngrese la contraseña (o 'salir' para terminar): ");

            string input = Console.ReadLine();

            if (input.ToLower() == "salir")
            {
                Console.WriteLine("Gracias por usar el validador de contraseñas. ¡Hasta pronto!");
                break;
            }

            ValidarContrasena(input);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void ValidarContrasena(string contrasena)
    {
        bool esValida = true;
        string mensaje = "\nResultado de la validación:\n";

        // Validar longitud mínima de 8 caracteres
        if (contrasena.Length < 8)
        {
            esValida = false;
            mensaje += "- La contraseña debe tener al menos 8 caracteres.\n";
        }

        // Validar al menos una mayúscula
        if (!Regex.IsMatch(contrasena, @"[A-Z]"))
        {
            esValida = false;
            mensaje += "- La contraseña debe contener al menos una letra mayúscula.\n";
        }

        // Validar al menos una minúscula
        if (!Regex.IsMatch(contrasena, @"[a-z]"))
        {
            esValida = false;
            mensaje += "- La contraseña debe contener al menos una letra minúscula.\n";
        }

        // Validar al menos un número
        if (!Regex.IsMatch(contrasena, @"\d"))
        {
            esValida = false;
            mensaje += "- La contraseña debe contener al menos un número.\n";
        }

        // Validar al menos un carácter especial (!@#$%^&*)
        if (!Regex.IsMatch(contrasena, @"[!@#$%^&*]"))
        {
            esValida = false;
            mensaje += "- La contraseña debe contener al menos un carácter especial (!@#$%^&*).\n";
        }

        if (esValida)
        {
            mensaje += "\n¡La contraseña es válida!";
        }
        else
        {
            mensaje += "\nLa contraseña NO es válida.";
        }

        Console.WriteLine(mensaje);
    }
}