using System.Collections.Generic;

namespace Lab7
{
    class Comparer: IComparer<RationalNumber>
    {
        public int Compare(RationalNumber a, RationalNumber b)
        {
            if (a.numerator * b.denominator > b.numerator * a.denominator)
            {
                return 1;
            }
            else if ((a.numerator == b.numerator) && (a.denominator == b.denominator))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
