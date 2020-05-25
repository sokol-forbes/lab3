using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{ 
    class People
    {
        public string name;
        public string lastname;
        public string age;
        public People()
        {
            name = "underfined";
            lastname = "underfined";
            age = "underfined";
        }

        public People(string name,
                       string lastname,
                         string age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }

        public void PrintPeople()
        {
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("LastName : {0}", lastname);
            Console.WriteLine("Age : {0}", age);

        }
    }
}
