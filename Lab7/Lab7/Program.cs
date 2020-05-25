using static System.Console;
using System;
//using System.Object;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber[] rationNumbers = null;

            RationNumberArrFiller(ref rationNumbers);

            DataOutput(rationNumbers);

            TwoNumsComparing(rationNumbers);
        }

        public static void RationNumberArrFiller(ref RationalNumber[] rationNumbers)
        {
            string numberQuantityStr;

            WriteLine("How many numbers do you whant to create?");
            numberQuantityStr = ReadLine();

            if (int.Parse(numberQuantityStr) <= 0)
            {
                Write("wrong number entered");
                return;
            }

            rationNumbers = new RationalNumber[int.Parse(numberQuantityStr)];

            for (int i = 0; i < rationNumbers.Length; i++)
            {
                string entringNumStr;

                int numerator;
                int denumerator;

                for (; ;)
                {
                    WriteLine("Enter numerator please");
                    entringNumStr = ReadLine();

                    if ((string.IsNullOrEmpty(entringNumStr)) 
                        || (int.Parse(entringNumStr) < 0))
                    {
                        WriteLine("Wrong value was entered, " +
                            "try again please!");
                    }
                    else
                    {
                        numerator = int.Parse(entringNumStr);

                        break;
                    }
                }

                for (; ;)
                {
                    WriteLine("Enter denumerator please");
                    entringNumStr = ReadLine();

                    if ((string.IsNullOrEmpty(entringNumStr)) 
                        || (int.Parse(entringNumStr) < 0))
                    {
                        WriteLine("Wrong value was entered, " +
                            "try again please!");
                    }
                    else
                    {
                        denumerator = int.Parse(entringNumStr);

                        break;
                    }
                }

                rationNumbers[i] = new RationalNumber(numerator, denumerator);
            }
        }

        public static void DataOutput(RationalNumber[] rationNumbers)
        {
            for (int i = 0; i < rationNumbers.Length; i++)
            {
                Write($"{i + 1})");

                WriteLine(rationNumbers[i].numerator.ToString() + "/" 
                    + rationNumbers[i].denominator.ToString());

                WriteLine((rationNumbers[i].numerator /
                    rationNumbers[i].denominator).ToString());

                WriteLine("");
            }
        }

        public static void TwoNumsComparing(RationalNumber[] rationNumbers)
        {
            string numToCompStr;

            int firstNumToComp = 0;
            int secondNumToComp = 0;

            WriteLine("What numbers you whant to compare?" +
                " Enter its count numbersat array");

            for (; ;)
            {
                WriteLine("Enter first number to compare");
                numToCompStr = ReadLine();
                if ((string.IsNullOrEmpty(numToCompStr)) 
                    || (int.Parse(numToCompStr) < 0)
                    || int.Parse(numToCompStr) > rationNumbers.Length)
                {
                    WriteLine("Wrong value was entered, " +
                        "try again please!");
                }
                else
                {
                    firstNumToComp = int.Parse(numToCompStr);
                }

                WriteLine("Enter second number to compare");
                numToCompStr = ReadLine();

                if ((string.IsNullOrEmpty(numToCompStr)) 
                    || (int.Parse(numToCompStr) < 0)
                    || int.Parse(numToCompStr) > rationNumbers.Length)
                {
                    WriteLine("Wrong value was entered, " +
                        "try again please!");
                }
                else
                {
                    secondNumToComp = int.Parse(numToCompStr);

                    break;
                }
            }

            WriteLine(rationNumbers[firstNumToComp]
                == rationNumbers[secondNumToComp]);

            Comparer objComp = new Comparer();

            if (objComp.Compare(rationNumbers[firstNumToComp],
                rationNumbers[secondNumToComp]) == 0)
            {
                WriteLine("These numbers are equal!");
            }
            else if(objComp.Compare(rationNumbers[firstNumToComp], 
                rationNumbers[secondNumToComp]) == 1)
            {
                WriteLine("The first number is " +
                    "bigger than second one");
            }
            else
            {
                WriteLine("The second number is " +
                    "bigger than first one");
            }
        }
    }
}