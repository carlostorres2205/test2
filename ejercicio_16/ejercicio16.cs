using System;
using System.Collections.Generic;

class Programa
{
    // Lista global de usuarios
    static List<string> usuarios = new List<string>();

    // Método para registrar un usuario
    static void RegistrarUsuario(string nombre)
    {
        if (ValidarUsuario(nombre))
        {
            Console.WriteLine($" El usuario '{nombre}' ya existe.");
        }
        else
        {
            usuarios.Add(nombre);
            Console.WriteLine($" Usuario '{nombre}' registrado con éxito.");
        }
    }

    // Método para validar si un usuario ya existe
    static bool ValidarUsuario(string nombre)
    {
        return usuarios.Contains(nombre);
    }

    // Método para mostrar todos los usuarios
    static void MostrarUsuarios()
    {
        Console.WriteLine("\n Lista de usuarios registrados:");
        if (usuarios.Count == 0)
        {
            Console.WriteLine("   (No hay usuarios registrados aún)");
        }
        else
        {
            foreach (var user in usuarios)
            {
                Console.WriteLine($"   - {user}");
            }
        }
    }

    // Programa principal
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n=== Sistema de Registro de Usuarios ===");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Validar usuario");
            Console.WriteLine("3. Mostrar todos los usuarios");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa el nombre del nuevo usuario: ");
                    string nuevo = Console.ReadLine();
                    RegistrarUsuario(nuevo);
                    break;

                case 2:
                    Console.Write("Ingresa el nombre del usuario a validar: ");
                    string nombre = Console.ReadLine();
                    if (ValidarUsuario(nombre))
                        Console.WriteLine($" El usuario '{nombre}' está registrado.");
                    else
                        Console.WriteLine($" El usuario '{nombre}' NO existe.");
                    break;

                case 3:
                    MostrarUsuarios();
                    break;

                case 4:
                    Console.WriteLine(" Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine(" Opción inválida, intenta de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }
}