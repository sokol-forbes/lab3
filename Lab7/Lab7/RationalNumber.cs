using static System.Console;
using System.Text;
using System;

namespace Lab7
{
    class RationalNumber : IComparable<RationalNumber>, IEquatable<RationalNumber>
    {
        public readonly int numerator;
        public readonly int denominator;

        public RationalNumber(int numerator) : this(numerator, 1) {}

        public RationalNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override bool Equals(object numberToCompare)
        {
            return Equals(numberToCompare);
        }

        public bool Equals(RationalNumber numberToCompare)
        {
            RationalNumber RatNumberToComp;
            RatNumberToComp = (RationalNumber)numberToCompare;

            return (numerator == RatNumberToComp.numerator &&
                denominator == RatNumberToComp.denominator);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(RationalNumber comparingNum)
        { 
                return this.numerator.CompareTo(comparingNum);
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            if (a.denominator != 0 && b.denominator != 0)
            {
                return a.numerator * b.denominator
                    > b.numerator * a.denominator;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(RationalNumber number1, RationalNumber number2)
        {
            return number1.Equals(number2);
        }

        public static bool operator !=(RationalNumber number1, RationalNumber number2)
        {
            return number1.Equals(number2);
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            if (a.denominator != 0 && b.denominator != 0)
            {
                return a.numerator * b.denominator
                    < b.numerator * a.denominator;
            }
            else
            {
                return false;
            }
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            if (a.denominator != 0 && b.denominator != 0)
            {
                return new RationalNumber(a.numerator * b.denominator + 
                    b.numerator * a.denominator, 
                    a.denominator * b.denominator);
            }
            else
            {
                return 0;
            }
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            if (a.denominator != 0 && b.denominator != 0)
            {
                return new RationalNumber(a.numerator * b.denominator -
                    b.numerator * a.denominator, 
                    a.denominator * b.denominator);
            }
            else
            {
                return 0;
            }
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            if (a.denominator != 0 && b.denominator != 0)
            {
                return new RationalNumber(a.numerator * b.numerator, 
                    a.denominator * b.denominator);
            }
            else
            {
                return 0;
            }
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            if (a.denominator != 0 && b.denominator != 0)
            {
                return new RationalNumber(a.numerator * b.denominator, 
                    a.denominator * b.numerator);
            }
            else
            {
                return 0;
            }
        }

        public static implicit operator RationalNumber(string number)
        {
            return Parse(number);
        }

        public static explicit operator string(RationalNumber number)
        {
            return number.ToString();
        }

        public static implicit operator RationalNumber(int number)
        {
            return new RationalNumber(number);
        }

        public static explicit operator int(RationalNumber number)
        {
            return Convert.ToInt32(number.numerator / number.denominator);
        }

        public static implicit operator RationalNumber(double doubleNumber)
        {
            return new RationalNumber(Convert.ToInt32(doubleNumber * 100), 100);
        }

        public static explicit operator double(RationalNumber number)
        {
            return number.numerator / number.denominator;
        }

        public override string ToString()
        {

            return (numerator.ToString() + "/"
                  + denominator.ToString());
        }

        public static RationalNumber Parse(string rationNumStr)
        {
            try
            {
                if (!string.IsNullOrEmpty(rationNumStr))
                {
                    if (rationNumStr.IndexOf('/') != -1)
                    {
                        string[] numbers = rationNumStr.Split('/');

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (int.Parse(numbers[i]) <= 0
                                || string.IsNullOrEmpty(numbers[i]))
                            {
                                throw new FormatException("Invalid value parcing!");
                            }
                        }

                        return new RationalNumber(int.Parse(numbers[0]),
                            int.Parse(numbers[1]));
                    }
                    else
                    {
                        double enteredNum;

                        try
                        {
                            int fractional;
                            int wholeNum;

                            enteredNum = Convert.ToDouble(rationNumStr);

                            wholeNum = Convert.ToInt32(Math.Floor(enteredNum));
                            fractional = Convert.ToInt32(Math.Round((enteredNum
                                - wholeNum), 3) * 1000);

                            return new RationalNumber((wholeNum * 1000) + fractional, 1000);
                        }
                        catch (FormatException)
                        {
                            return 0;
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid value parcing!");
                }
            }
            catch (FormatException)
            {
                return 0;
            }
        }
    }
}