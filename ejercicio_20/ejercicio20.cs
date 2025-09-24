class Program
{
    static long numeroOriginal; // Variable global para el número original

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------Verificador de Números Capicúa--------");
            Console.Write("\nIngrese un número entero positivo (o 'salir' para terminar): ");

            string input = Console.ReadLine();

            if (input.ToLower() == "salir")
            {
                Console.WriteLine("haska la uska");
                break;
            }

            // Validar que la entrada sea un número entero positivo
            if (!long.TryParse(input, out numeroOriginal) || numeroOriginal < 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero positivo.");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            // Obtener el número invertido
            long numeroInvertido = InvertirNumero();

            // Comparar el número original con el invertido
            if (numeroOriginal == numeroInvertido)
            {
                Console.WriteLine($"\nEl número {numeroOriginal} es capicúa.");
            }
            else
            {
                Console.WriteLine($"\nEl número {numeroOriginal} NO es capicúa. (Invertido: {numeroInvertido})");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    static long InvertirNumero()
    {
        long numero = numeroOriginal; // Usar la variable global
        long invertido = 0;

        // Invertir el número usando operadores matemáticos
        while (numero > 0)
        {
            long digito = numero % 10; // Obtener el último dígito
            invertido = (invertido * 10) + digito; // Construir el número invertido
            numero /= 10; // Eliminar el último dígito
        }

        return invertido;
    }
}