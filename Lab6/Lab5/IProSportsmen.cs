using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    interface IProSportsmen : ISportsmen
    {
        string RibbonsQuantity { get; set; }
        string Experience { get; set; }

        void PrintProSportsmen();
    }
}
