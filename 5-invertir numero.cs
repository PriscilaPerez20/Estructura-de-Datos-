//Programa 5.
//Invertir el orden de los dígitos de un número entero positivo mediante llamdas recursivas.
using System;

class Program
{
    static long Invertir(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;
        else
            return Invertir(n / 10, resultado * 10 + n % 10);
    }

    static void Main()
    {
        Console.Write("Ingrese un número positivo: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("El número ingresado no es positivo.");
        }
        else
        {
            long resultado = Invertir(n);
            Console.WriteLine($"El número invertido es: {resultado}");
        }
    }
}