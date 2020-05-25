using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class People : IPeople, IGetInfo
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }

        public People()
            : this("underfined", "underfined", "underfined") {}

        public People(string name,
            string lastname, string age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }

        public void PrintPeople()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("LastName : {0}", Lastname);
            Console.WriteLine("Age : {0}", Age);
        }

        public virtual object Clone()
        {
            return new People
            {
                Name = this.Name,
                Lastname = this.Lastname,
                Age = this.Age
            };
        }
    }
}
