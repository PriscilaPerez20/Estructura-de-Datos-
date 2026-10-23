//Programa 3.
//Calcular la suma de todos los números desde 1 hasta el n.
using System;
    class program
{
    static int suma(int n)
    {
        if (n <= 0)
            return 0;

        return n + suma(n - 1);
        
    }
    static void Main()
    {
        Console.Write("ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

                if(n<= 0 || n > 10000)
        {
            Console.WriteLine("ingresa un numero entre 0 y 10000 ");
            return;
        }
                Console.WriteLine("La suma es: " + suma(n));
    }
}
