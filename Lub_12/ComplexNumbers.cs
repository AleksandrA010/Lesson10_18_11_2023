using System;
using System.CodeDom;

namespace Lub_12
{
    internal class ComplexNumbers
    {
        public double RealPart { get; private set; }
        public double ComplexPart { get; private set; }
        public ComplexNumbers()
        {
            RealPart = 0;
            ComplexPart = 0;
        }
        public ComplexNumbers(double realPart)
        {
            RealPart = realPart;
            ComplexPart = 0;
        }
        public ComplexNumbers(double realPart, double complexPart) : this(realPart)
        {
            ComplexPart = complexPart;
        }
        public static ComplexNumbers operator +(ComplexNumbers left, ComplexNumbers right)
        {
            double realPart = left.RealPart + right.RealPart;
            double complexPart = left.ComplexPart + right.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }
        public static ComplexNumbers operator +(ComplexNumbers left, double right)
        {
            double realPart = left.RealPart + right;
            double complexPart = left.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }
        public static ComplexNumbers operator +(double left, ComplexNumbers right)
        {
            double realPart = left + right.RealPart;
            double complexPart = right.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }
        public static ComplexNumbers operator -(ComplexNumbers left, ComplexNumbers right)
        {
            double realPart = left.RealPart - right.RealPart;
            double complexPart = left.ComplexPart - right.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }
        public static ComplexNumbers operator -(ComplexNumbers left, double right)
        {
            double realPart = left.RealPart - right;
            double complexPart = left.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }
        public static ComplexNumbers operator -(int left, ComplexNumbers right)
        {
            double realPart = left - right.RealPart;
            double complexPart = right.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }
        public static ComplexNumbers operator *(ComplexNumbers left, ComplexNumbers right)
        {
            double realPart = left.RealPart * right.RealPart;
            double complexPart = left.ComplexPart * right.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }
        public static ComplexNumbers operator *(ComplexNumbers left, double right)
        {
            double realPart = left.RealPart * right;
            double complexPart = left.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }
        public static ComplexNumbers operator *(int left, ComplexNumbers right)
        {
            double realPart = left * right.RealPart;
            double complexPart = right.ComplexPart;
            return new ComplexNumbers(realPart, complexPart);
        }

        public override string ToString()
        {
            if (ComplexPart < 0)
            {
                return $"{RealPart} + ({ComplexPart}i)";
            }
            return $"{RealPart} + {ComplexPart}i";
        }
        public static bool operator ==(ComplexNumbers right, ComplexNumbers left)
        {
            if ((right.RealPart == left.RealPart) & (right.ComplexPart == left.ComplexPart))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(ComplexNumbers right, ComplexNumbers left)
        {
            if ((right.RealPart != left.RealPart) | (right.ComplexPart != left.ComplexPart))
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumbers num)
            {
                if ((RealPart == num.RealPart) & (ComplexPart == num.ComplexPart))
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            if (ComplexPart < 0)
            {
                return $"{RealPart} + ({ComplexPart}i)".GetHashCode();
            }
            return $"{RealPart} + {ComplexPart}i".GetHashCode();
        }
    }
}
