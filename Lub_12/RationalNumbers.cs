using System;
using System.Security.Policy;
using System.Xml.Linq;

namespace Lub_12
{
    internal class RationalNumbers
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public RationalNumbers()
        {
            Numerator = 0;
            Denominator = 1;
        }
        public RationalNumbers(int numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }
        public RationalNumbers(int numerator, int denominator) : this(numerator)
        {
            Denominator = denominator;
        }
        public static bool operator ==(RationalNumbers lhs, RationalNumbers rhs)
        {
            if((lhs.Denominator == rhs.Denominator) & (lhs.Numerator == rhs.Numerator))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(RationalNumbers lhs, RationalNumbers rhs)
        {
            if ((lhs.Denominator != rhs.Denominator) | (lhs.Numerator != rhs.Numerator))
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj is RationalNumbers num)
            {
                if ((Denominator == num.Denominator) & (Numerator == num.Numerator))
                {
                    return true;
                }
            }
            return false;
        }
        public static RationalNumbers operator +(RationalNumbers lhs, RationalNumbers rhs)
        {
            RationalNumbers rationalNumbers = new RationalNumbers()
            {
                Numerator = lhs.Numerator * rhs.Denominator + rhs.Numerator * lhs.Denominator,
                Denominator = lhs.Denominator * rhs.Denominator
            };
            return rationalNumbers;
        }
        public static RationalNumbers operator +(int lhs, RationalNumbers rhs)
        {
            return new RationalNumbers(lhs * rhs.Denominator + rhs.Numerator, rhs.Denominator);
        }
        public static RationalNumbers operator +(RationalNumbers lhs, int rhs)
        {
            return new RationalNumbers(lhs.Numerator + rhs * lhs.Denominator, lhs.Denominator);
        }
        public static RationalNumbers operator -(RationalNumbers lhs, RationalNumbers rhs)
        {
            RationalNumbers rationalNumbers = new RationalNumbers()
            {
                Numerator = lhs.Numerator * rhs.Denominator - rhs.Numerator * lhs.Denominator,
                Denominator = lhs.Denominator * rhs.Denominator
            };
            return rationalNumbers;
        }
        public static RationalNumbers operator -(int lhs, RationalNumbers rhs)
        {
            return new RationalNumbers(lhs * rhs.Denominator - rhs.Numerator, rhs.Denominator);
        }
        public static RationalNumbers operator -(RationalNumbers lhs, int rhs)
        {
            return new RationalNumbers(lhs.Numerator - rhs * lhs.Denominator, lhs.Denominator);
        }
        public static bool operator >(RationalNumbers lhs, RationalNumbers rhs)
        {
            int lhsNumerator = lhs.Numerator * rhs.Denominator;
            int rhsNumerator = rhs.Numerator * lhs.Denominator;
            if (lhsNumerator > rhsNumerator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(RationalNumbers lhs, RationalNumbers rhs)
        {
            int lhsNumerator = lhs.Numerator * rhs.Denominator;
            int rhsNumerator = rhs.Numerator * lhs.Denominator;
            if (lhsNumerator < rhsNumerator)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(RationalNumbers lhs, RationalNumbers rhs)
        {
            int lhsNumerator = lhs.Numerator * rhs.Denominator;
            int rhsNumerator = rhs.Numerator * lhs.Denominator;
            if (lhsNumerator >= rhsNumerator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(RationalNumbers lhs, RationalNumbers rhs)
        {
            int lhsNumerator = lhs.Numerator * rhs.Denominator;
            int rhsNumerator = rhs.Numerator * lhs.Denominator;
            if (lhsNumerator <= rhsNumerator)
            {
                return true;
            }
            return false;
        }
        public static RationalNumbers operator ++(RationalNumbers number)
        {
            return new RationalNumbers(number.Numerator + number.Denominator, number.Denominator);
        }
        public static RationalNumbers operator --(RationalNumbers number)
        {
            return new RationalNumbers(number.Numerator - number.Denominator, number.Denominator);
        }
        public static RationalNumbers operator *(RationalNumbers lhs, RationalNumbers rhs)
        {
            return new RationalNumbers(lhs.Numerator * rhs.Numerator, lhs.Denominator * rhs.Denominator);
        }
        public static RationalNumbers operator *(RationalNumbers lhs, int rhs)
        {
            return new RationalNumbers(lhs.Numerator * rhs, lhs.Denominator);
        }
        public static RationalNumbers operator *(int lhs, RationalNumbers rhs)
        {
            return new RationalNumbers(rhs.Numerator * lhs, rhs.Denominator);
        }
        public static RationalNumbers operator /(RationalNumbers lhs, RationalNumbers rhs)
        {
            return new RationalNumbers(lhs.Numerator * rhs.Denominator, lhs.Numerator * rhs.Denominator);
        }
        public static RationalNumbers operator /(RationalNumbers lhs, int rhs)
        {
            return new RationalNumbers(lhs.Numerator, lhs.Denominator * rhs);
        }
        public static RationalNumbers operator /(int lhs, RationalNumbers rhs)
        {
            return new RationalNumbers(rhs.Numerator, rhs.Denominator * lhs);
        }
        public static int operator %(RationalNumbers lhs, RationalNumbers rhs)
        {
            int Numerator = lhs.Numerator * rhs.Denominator;
            int Denominator = lhs.Numerator * rhs.Denominator;
            return Numerator % Denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        public override int GetHashCode()
        {
            return ((double)(Numerator / Denominator)).GetHashCode();
        }
    }
}
