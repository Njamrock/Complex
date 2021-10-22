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
            Console.WriteLine($"Addition: ({a.Real} + {a.Imaginary}*i) + ({b.Real} + {b.Imaginary}*i) = {c.Real} + {c.Imaginary}*i");
            Console.WriteLine($"Addition: ({a.ToString()}) + ({b.ToString()}) = {c.ToString()}\n");

            a = new Complex(3, 4);
            b = new Complex(2, 1);
            Complex d = a - b;
            Console.WriteLine($"Subtraction: ({a.Real} + {a.Imaginary}*i) - ({b.Real} + {b.Imaginary}*i) = {d.Real} + {d.Imaginary}*i");
            Console.WriteLine($"Subtraction: ({a.ToString()}) - ({b.ToString()}) = {d.ToString()}\n");


            a = new Complex(1, 2);
            b = new Complex(3, 4);
            Complex e = a * b;
            Console.WriteLine($"Multiplication: ({a.Real} + {a.Imaginary}*i) * ({b.Real} + {b.Imaginary}*i) = {e.Real} + {e.Imaginary}*i");
            Console.WriteLine($"Multiplication: ({a.ToString()}) * ({b.ToString()}) = {e.ToString()}\n");

            a = new Complex(5, 5);
            b = new Complex(1, 2);
            Complex f = a / b;
            Console.WriteLine($"Division: ({a.Real} + {a.Imaginary}*i) / ({b.Real} + {b.Imaginary}*i) = {f.Real} + {f.Imaginary}*i");
            Console.WriteLine($"Division: ({a.ToString()}) / ({b.ToString()}) = {f.ToString()}\n");

            double g = 4;
            Console.WriteLine($"Roots of number {g} are: {Complex.Sqrt(g)[0].Real} + {Complex.Sqrt(g)[0].Imaginary}*i , {Complex.Sqrt(g)[1].Real} + {Complex.Sqrt(g)[1].Imaginary}*i");
            Console.WriteLine($"Roots of number {g} are: {Complex.Sqrt(g)[0].ToString()} , {Complex.Sqrt(g)[1].ToString()}\n");

            g = -4;
            Console.WriteLine($"Roots of number {g} are: {Complex.Sqrt(g)[0].Real} + {Complex.Sqrt(g)[0].Imaginary}*i , {Complex.Sqrt(g)[1].Real} + {Complex.Sqrt(g)[1].Imaginary}*i");
            Console.WriteLine($"Roots of number {g} are: {Complex.Sqrt(g)[0].ToString()} , {Complex.Sqrt(g)[1].ToString()}\n");
        }
    }
}
