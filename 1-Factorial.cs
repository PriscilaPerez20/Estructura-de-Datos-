//Prgrama 1.
//Calcular el factorial de un número entero no negativo.
using System;

class Program
{
    static long Fibanocci(int n)
    {
        if (n <= 0)
            return n;

        return n * Fibanocci(n - 1) + Fibanocci(n - 2);
    }

    static void Main()
    {
        Console.Write("Ingresa una posicion: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n >20)

        {
            Console.WriteLine("Ingrese un número entre 0 y 40");
            return;
        }

        Console.WriteLine("Fibanocci: " + Fibanocci (n));
    }
}

