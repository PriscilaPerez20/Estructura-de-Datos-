using System;
class program
{
    static int sumaDigitos(int n)
    {
        if (n == 0)
            return 0;

        return n % 10 + sumaDigitos(n / 10);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        if ( n < 0)
        {
            Console.WriteLine("El numero debe ser positivo.");
            return;
        }
        Console.WriteLine("Suma de digitos: " + sumaDigitos(n));

    }
}
