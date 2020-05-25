using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    interface ISportsmen : IPeople
    {
        string Level { get; set; }
        string Team { get; set; }

        void PrintSportsmen();
    }
}
