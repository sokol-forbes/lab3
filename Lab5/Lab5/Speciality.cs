using System;

using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Speciality : ProSportsmen
    {
        public string Education { get; set; }

        public string SpecialyM { get; set; }

        public Speciality()
            : this("underfined", "underfined", "underfined",
            "underfined", "underfined", "underfined", "underfined",
            "underfined", "underfined", "underfined", "underfined")
        {}

        public Speciality(string name, string lastname,
            string age, string level, string team,
            string speciality, string education,
            string ribbonsQuantity, string experience,
            string deadLift, string benchPress)
            : base(level, team, name, lastname, age,
                  ribbonsQuantity, experience,
                  deadLift, benchPress)
        {
            this.SpecialyM = speciality;
            this.Education = education;
        }

        public void PrintData()
        {
            PrintProSportsmen();

            Console.WriteLine("Specialy : {0}", SpecialyM);
            Console.WriteLine("Education : {0}", Education);
        }
    }
}