using System;
class program
{
    static void cuentaA(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("B:" + n);
        cuentaA(n - 1);
    }
    static void Main(string[] args)
    {
        Console.Write("Ingrese un numero inicial: ");
        int n = int.Parse(Console.ReadLine());

        if(n<0 || n>1000)
        {
            Console.WriteLine("ingrese un numero entre 0 y 1000 ");
            return;
        }
        cuentaA(n);
    }
}
