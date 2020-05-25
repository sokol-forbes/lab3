using System;

using System.Collections.Generic;
using System.Text;

namespace Lab3Copy
{
    class Speciality : Sportsmen
    {
        private string education;

        public string SpecialyM { get; set; }

        public Speciality()
            : this("underfined", "underfined", "underfined",
            "underfined", "underfined", "underfined", "underfined")
        {}

        public Speciality(string name, string lastname, 
            string age, string level, string team, 
            string speciality, string education) 
            : base(level, team, name, lastname, age)
        {
            this.SpecialyM = speciality;
            this.education = education;
        }

        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        public void PrintData()
        {
            PrintSportsmen();

            Console.WriteLine("Specialy : {0}", SpecialyM);
            Console.WriteLine("Education : {0}", education);
        }
    }
}