//Programa 10.
//Convertir un número entero no negativo a si representacion binaria usando dos métodos que se llamen mutuamente.
using System;

class Program
{
    static void BinarioA(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }

        BinarioB(n / 2);
        Console.Write(n % 2);
    }

    static void BinarioB(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }

        BinarioA(n / 2);
        Console.Write(n % 2);
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Ingrese un número negativo: ");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            BinarioA(n);
        }
        Console.WriteLine();
    }
}