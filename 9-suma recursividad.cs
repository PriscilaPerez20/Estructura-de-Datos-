//Programa 9.
//Calcular la suma de los números desde 1 hasta n utilizando dos mmétodos que se llamen mutuamente.
using System;
class program
{
    static int sumaA(int n)
    {
        if (n <= 0)
            return 0;

        return n + sumaB(n - 1);

    }
    static int sumaB(int n)
    {
        if (n <= 0)
            return 0;

        return sumaA(n - 1);

    }
    static void Main(string[] args)
    {
        Console.Write("ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        if ( n < 0 || n > 10000)
        {
            Console.WriteLine("ingrese un numero entre 0 y 10000");
            return;

        }
        Console.WriteLine("La suma es: " + sumaA(n));
    }
}
