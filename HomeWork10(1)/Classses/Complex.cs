using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_1_.Classses
{
    public class Complex
    {
        readonly double real;
        readonly double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                Complex c = (Complex)obj;
                if (real == c.real && imaginary == c.imaginary)
                {
                    return true;
                }
            }
            else if (imaginary == 0)
            {
                if (int.TryParse(obj.ToString(), out int temp))
                {
                    if (real == temp)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            if (imaginary == 0)
            {
                return $"{real}";
            }
            else if (imaginary < 0)
            {
                return $"{real} - {Math.Abs(imaginary)}i";
            }
            return $"{real} + {imaginary}i";
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }

        public static Complex operator +(Complex a, double b_)
        {
            Complex b = new Complex(b_, 0);
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }

        public static Complex operator -(Complex a, double b_)
        {
            Complex b = new Complex(b_, 0);
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + b.real * a.imaginary);
        }

        public static Complex operator *(Complex a, double b_)
        {
            Complex b = new Complex(b_, 0);
            return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + b.real * a.imaginary);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((double)(a.real * b.real + a.imaginary * b.imaginary) / (double)(b.real * b.real + b.imaginary * b.imaginary),
                (double)(b.real * a.imaginary - a.real * b.imaginary) / (double)(b.real * b.real + b.imaginary * b.imaginary));
        }

        public static Complex operator /(Complex a, double b_)
        {
            Complex b = new Complex(b_, 0);
            return new Complex((double)(a.real * b.real + a.imaginary * b.imaginary) / (double)(b.real * b.real + b.imaginary * b.imaginary),
                (double)(b.real * a.imaginary - a.real * b.imaginary) / (double)(b.real * b.real + b.imaginary * b.imaginary));
        }
    }
}
