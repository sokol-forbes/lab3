using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    interface IPeople : ICloneable
    {
        string Name { get; set; }
        string Lastname { get; set; }
        string Age { get; set; }

        void PrintPeople();
    }
}
