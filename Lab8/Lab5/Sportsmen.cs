
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Sportsmen : People, ISportsmen, IGetInfo
    {
        public string Level { get; set; }
        public string Team { get; set; }

        protected Sportsmen() : this("underfined", 
            "underfined", "underfined", "underfined", "underfined")
        {}

        protected Sportsmen(string level, string team,
            string name, string lastname, string age)
            : base(name, lastname, age)
        {
            this.Level = level;
            this.Team = team;
        }

        public void PrintSportsmen()
        {
            PrintPeople();

            Console.WriteLine("Team : {0}", Team);
            Console.WriteLine("Level : {0}", Level);
        }

        public override object Clone()
        {
            return new Sportsmen
            {
                Name = this.Name,
                Lastname = this.Lastname,
                Age = this.Age,
                Level = this.Level,
                Team = this.Team
            };
        }
    }
}