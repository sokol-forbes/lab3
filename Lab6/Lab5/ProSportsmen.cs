using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    readonly struct LiftInfo
    {
        public readonly string deadLift;
        public readonly string benchPress;

        public LiftInfo(string deadLift, string benchPress)
        {
            this.deadLift = deadLift;
            this.benchPress = benchPress;
        }
    }

    class ProSportsmen : Sportsmen, IProSportsmen, IGetInfo
    {
        public string RibbonsQuantity { get; set; }
        public string Experience { get; set; }

        public LiftInfo ProSportsmenResults;

        public ProSportsmen()
            : this("underfined",
            "underfined", "underfined", "underfined",
            "underfined", "underfined", "underfined",
            "undefined", "undefined")
        {}

        public ProSportsmen(string level, string team,
            string name, string lastname, string age,
            string ribbonsQuantity, string experience,
            string deadLift, string benchPress)
            : base(level, team, name, lastname, age)
        {
            this.RibbonsQuantity = ribbonsQuantity;
            this.Experience = experience;

            ProSportsmenResults = new LiftInfo(deadLift, benchPress);
        }

        public void PrintProSportsmen()
        {
            PrintSportsmen();

            Console.WriteLine("Quantity of ribbons : {0}", 
                RibbonsQuantity);
            Console.WriteLine("Level of experience : {0}", 
                Experience);
            Console.WriteLine("Dead lift : {0}", 
                ProSportsmenResults.deadLift);
            Console.WriteLine("Bench press : {0}", 
                ProSportsmenResults.benchPress);
        }

        public override object Clone()
        {
            return new ProSportsmen
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
