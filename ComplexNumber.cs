using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Calculator
{
    class ComplexNumber
    {
        double realPart;
        double imgPart;

        // Constructors
        public ComplexNumber()
        {
            realPart = 0;
            imgPart = 0;
        }
        public ComplexNumber(double rNum, double iNum)
        {
            realPart = rNum;
            imgPart = iNum;
        }

        // Double Converter
        public static implicit operator ComplexNumber(double rNum)
        {
            return new ComplexNumber(rNum, 0);
        }

        // Properties
        public double Real
        {
            get { return realPart; }
            set { realPart = value; }
        }
        public double Imaginary
        {
            get { return imgPart; }
            set { imgPart = value; }
        }

        //Comparison Operators and Functions
        public static bool operator ==(ComplexNumber z1, ComplexNumber z2)
        {
            if (z1.Real == z2.Real && z1.Imaginary == z2.Imaginary)
                return true;
            else return false;
        }
        public static bool operator !=(ComplexNumber z1, ComplexNumber z2)
        {
            if (z1.Real != z2.Real || z1.Imaginary != z2.Imaginary)
                return true;
            else return false;
        }
        public override bool Equals(object obj)
        {
            ComplexNumber compObj = obj as ComplexNumber;
            if (compObj == null)
                return false;
            else
            {
                return compObj.Real == this.Real && compObj.Imaginary == this.Imaginary;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Math Operations and Functions
        public static ComplexNumber operator -(ComplexNumber z1)
        {
            return new ComplexNumber(-z1.Real, -z1.Imaginary);
        }
        public static ComplexNumber operator +(ComplexNumber z1, ComplexNumber z2)
        {
            return new ComplexNumber(z1.Real + z2.Real, z1.Imaginary + z2.Imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber z1, ComplexNumber z2)
        {
            return new ComplexNumber(z1.Real - z2.Real, z1.Imaginary - z2.Imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber z1, ComplexNumber z2)
        {
            double productReal = (z1.Real * z2.Real) - (z1.Imaginary * z2.Imaginary);
            double productImg = (z1.Real * z2.Imaginary) + (z1.Imaginary * z2.Real);
            return new ComplexNumber(productReal, productImg);
        }
        public ComplexNumber Inverse()
        {
            if (this != 0) // implicit conversion of double 0 & overriding !=
            {
                double magnitude = realPart * realPart + imgPart * imgPart;
                return new ComplexNumber(realPart / magnitude, -imgPart / magnitude);
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
        public static ComplexNumber operator /(ComplexNumber z1, ComplexNumber z2)
        {
            return z1 * z2.Inverse();
        }
        public ComplexNumber Conjugate()
        {
            return new ComplexNumber(Real, -Imaginary);
        }
        public double AbsoluteValue()
        {
            return Math.Sqrt(realPart * realPart + imgPart * imgPart);
        }

        // ToString function
        public override string ToString()
        {
            if (imgPart == 0)
            {
                return Real.ToString();
            }
            else if (realPart == 0)
            {
                return Imaginary.ToString() + "i";
            }
            else if (imgPart > 0)
            {
                return Real.ToString() + " + " + Imaginary.ToString() + "i";
            }
            else // imgPart < 0
            {
                return Real.ToString() + " - " + (-Imaginary).ToString() + "i";
            }
        }
    }
}
