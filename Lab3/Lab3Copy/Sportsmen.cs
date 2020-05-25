
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3Copy
{
    class Sportsmen : People
    {
        private string level;

        private string team;

        protected Sportsmen()
        {
            level = "underfined";
            team = "underfined";
        }

        protected Sportsmen(string level, string team, 
            string name, string lastname, string age) 
            : base(name, lastname, age)
        {
            this.level = level;
            this.team = team;
        }

        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Team
        {
            get { return team; }
            set { team = value; }
        }

        public void PrintSportsmen()
        {
            PrintPeople();
            Console.WriteLine("Team : {0}", team);
            Console.WriteLine("Level : {0}", level);
        }

    }
}