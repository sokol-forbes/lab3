using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    interface IGetInfo
    {
        void PrintData()
        {
            Console.WriteLine("Storage data outout");
        }

        void PrintProSportsmen()
        {
            Console.WriteLine("Info output about " +
                "profeccional sportsmen");
        }

        void PrintSportsmen()
        {
            Console.WriteLine("Info output about " +
                "sportsmen");
        }
        void PrintPeople()
        {
            Console.WriteLine("Info output about " +
               "person");
        }
    }
}
