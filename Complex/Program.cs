using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(3, 4);
            Complex c = a + b;

            Console.WriteLine(c.Real);
            Console.WriteLine(c.Imaginary);

            // TODO:01 Finish Lab2 Zadatak 3.)
        }
    }
}
