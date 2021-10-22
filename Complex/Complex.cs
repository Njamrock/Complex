using System;

namespace Complex
{
    struct Complex
    {
        public Complex(double realPart, double imaginaryPart)
        {
            this.real = realPart;
            this.imaginary = imaginaryPart;
        }

        public double Real
        {
            get { return this.real; }
            //set;
        }

        public double Imaginary
        {
            get { return this.imaginary; }
            //set;
        }

        public static Complex operator+(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex operator-(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static Complex operator*(Complex a, Complex b)
        {
            return new Complex(a.Real*b.Real - a.Imaginary*b.Imaginary, a.Real*b.Imaginary + a.Imaginary*b.Real);
        }

        public static Complex operator/(Complex a, Complex b)
        {
            return new Complex((a.Real * b.Real + a.Imaginary * b.Imaginary)/(b.real*b.real + b.Imaginary*b.imaginary), (a.Imaginary * b.Real - a.Real * b.Imaginary) / (b.real * b.real + b.Imaginary * b.imaginary));
        }

        public static Complex[] Sqrt(double number)
        {
            return number >= 0 ? new Complex[] { new Complex(Math.Sqrt(number), 0), new Complex(-Math.Sqrt(number), 0) } : new Complex[] { new Complex(0, Math.Sqrt(-number)), new Complex(0, -Math.Sqrt(-number)) };
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", this.real, this.Imaginary);

        }

        private double real;
        private double imaginary;
    }
}
