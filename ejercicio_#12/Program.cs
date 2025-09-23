//Simulacion de cajero Automatico

//Usar una variable global que represente el saldo de una cuenta bancaria 

//Metodo locales para

//Depositar dinero

//retirar dinero ( validando que no exceda el saldo )

//consultar saldo

using System;

class Program
{
    static int saldo = 1000; // variable global

    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("-------Bienvenido a BAC--------");
        Console.WriteLine("\nQue deseas hacer?\n1. Depositar saldo\n2. Retirar saldo\n3. Consultar saldo\n4.Salir");
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1) ;
        {
            Console.WriteLine("Monto a depositar : ");
            Depositar();
        }


    }

}