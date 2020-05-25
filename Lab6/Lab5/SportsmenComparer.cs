using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class SportsmenComparer : IComparer<Speciality>
    {
        public int Compare(Speciality firstSportsman,
            Speciality secondSportsman)
        {
            if (int.Parse(firstSportsman.Experience) >
                int.Parse(secondSportsman.Experience))
            {
                return 1;
            }
            else if (int.Parse(firstSportsman.Experience) ==
                int.Parse(secondSportsman.Experience))
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