using System;

using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Speciality : ProSportsmen
    {
        public delegate void Message();
        public delegate void CloneMessage(Speciality specialtyItem);
        public event CloneMessage ItemCloned;

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

        public void PrintData(Message outputMessage)
        {
            outputMessage?.Invoke(); 

            PrintProSportsmen();

            Console.WriteLine("Specialy : {0}", SpecialyM);
            Console.WriteLine("Education : {0}", Education);
        }

        public override object Clone()
        {
            ItemCloned?.Invoke(this);

            return new Speciality
            {
                Name = this.Name,
                Lastname = this.Lastname,
                Age = this.Age,
                Level = this.Level,
                Team = this.Team,
                RibbonsQuantity = this.RibbonsQuantity,
                Experience = this.Experience
            };
        }
    }
}