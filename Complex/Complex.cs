using System;
using System.Collections.Generic;
using System.Text;

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

        private double real;
        private double imaginary;
    }
}
