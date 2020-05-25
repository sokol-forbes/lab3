using System;

using System.Collections.Generic;
using System.Text;
namespace lab3
{
    class Speciality : Sportsmen
    {
        private string education;
        public Speciality(string name, string lastname, string age, string level, string team, string speciality, string education) : base(level,team,name,lastname,age)
       
        {
            this.SpecialyM = speciality;
            this.education = education;

        }                                                //constructor initialization

        public Speciality() : base()
        {
            SpecialyM = "underfined";
            education = "underfined";
        }

        public string Education
        {
            get { return education; }
            set { education = value; }
        }
        public string SpecialyM { get; set; }

        public void PrintData()
        {
            PrintSportsmen();
            Console.WriteLine("Specialy : {0}", SpecialyM);
            Console.WriteLine("Education : {0}", education);
        }

    }
}