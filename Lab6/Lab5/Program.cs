using System;

using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Programm
    {
        static List<Speciality> Storage = new List<Speciality>();

        static void Main(string[] args)
        {
            Menu();

            Console.WriteLine();
        }

        static void Add(int n)
        {
            Speciality form;

            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter lastname : ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter age : ");
            string age = Console.ReadLine();
            Console.WriteLine("Enter level : ");
            string level = Console.ReadLine();
            Console.WriteLine("Enter team : ");
            string team = Console.ReadLine();
            Console.WriteLine("Enter specialy : ");
            string speciality = Console.ReadLine();
            Console.WriteLine("Enter education  : ");
            string education = Console.ReadLine();
            Console.WriteLine("Enter ribbons quantity : ");
            string ribbonsQuantity = Console.ReadLine();
            Console.WriteLine("Enter experience level : ");
            string experience = Console.ReadLine();
            Console.WriteLine("Enter dead lift : ");
            string deadLift = Console.ReadLine();
            Console.WriteLine("Enter bench press : ");
            string benchPress = Console.ReadLine();

            form = new Speciality(name, lastname,
                age, level, team, speciality, education,
                ribbonsQuantity, experience, deadLift, benchPress);

            Storage.Add(form);
        }

        static void Add()
        {
            Speciality form;

            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter lastname : ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter age : ");
            string age = Console.ReadLine();
            Console.WriteLine("Enter level : ");
            string level = Console.ReadLine();
            Console.WriteLine("Enter team : ");
            string team = Console.ReadLine();
            Console.WriteLine("Enter specialy : ");
            string speciality = Console.ReadLine();
            Console.WriteLine("Enter education : ");
            string education = Console.ReadLine();
            Console.WriteLine("Enter ribbons quantity : ");
            string ribbonsQuantity = Console.ReadLine();
            Console.WriteLine("Enter experience level : ");
            string experience = Console.ReadLine();
            Console.WriteLine("Enter dead lift : ");
            string deadLift = Console.ReadLine();
            Console.WriteLine("Enter bench press : ");
            string benchPress = Console.ReadLine();

            form = new Speciality(name, lastname, 
                age, level, team, speciality, education, 
                ribbonsQuantity, experience, deadLift, benchPress);

            Storage.Add(form);
        }

        static void AddSportsmen()
        {
            Add();

            Console.Clear();

            Menu();
        }

        static void Change(int n)
        {
            int choice;

            Storage[n].PrintData();

            Console.WriteLine("What do you wan't to change?\n\n" +
                "1.All Form\n2.Name\n3.Lastname\n4.Age\n" +
                "5.Level\n6.Team\n7.Speciality\n8.Education\n" +
                "9.Ribbons quantity\n10.Experience11.Exit\n");

            choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (choice == 1)
            {
                Add(n);
            }
            else if (choice == 2)
            {
                Storage[n].Name = Console.ReadLine();
            }
            else if (choice == 3)
            {
                Storage[n].Lastname = Console.ReadLine();
            }
            else if (choice == 4)
            {
                Storage[n].Age = Console.ReadLine();
            }
            else if (choice == 5)
            {
                Storage[n].Level = Console.ReadLine();
            }
            else if (choice == 6)
            {
                Storage[n].Team = Console.ReadLine();
            }
            else if (choice == 7)
            {
                Storage[n].SpecialyM = Console.ReadLine();
            }
            else if (choice == 8)
            {
                Storage[n].Education = Console.ReadLine();
            }
            else if (choice == 9)
            {
                Storage[n].RibbonsQuantity = Console.ReadLine();
            }
            else if (choice == 10)
            {
                Storage[n].Experience = Console.ReadLine();
            }
            else if (choice != 12)
            {
                Console.WriteLine("Wrong choice");
            }

            Console.Clear();

            Menu();
        }

        static void Delete(int n)
        {
            int choice;

            Storage[n].PrintData();

            Console.Write("Did you wan't to delete this form?\n " +
                "1. Yes 2.No");

            choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (choice == 1)
            {
                Storage.RemoveAt(n);

                Console.Clear();

                Menu();
            }
            else if (choice == 2)
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Sinax Error.Try again");

                Delete(n);
            }
        }

        static void ChangeDelete()
        {
            int formNumber;

            Console.WriteLine("\nChoose '0' to Exit or choose Form to edit");

            formNumber = Convert.ToInt32(Console.ReadLine());

            if (formNumber != 0)
            {
                Console.WriteLine("Change(0) or Delete(1)?");

                int value = Convert.ToInt32(Console.ReadLine());

                if (value == 0)
                {
                    Console.Clear();

                    Change(formNumber - 1);
                }
                else if (value == 1)
                {
                    Console.Clear();

                    Delete(formNumber - 1);
                }
            }

            Menu();
        }

        static void CompareSportsmen()
        {
            SportsmenComparer comparer;
            comparer = new SportsmenComparer();

            int firstChoice;
            int secondChoice;

            Console.WriteLine("Enter sportsmen numbers wich" +
                "you whant ot campare");

            Console.WriteLine("Number of first sportsmen: ");
            firstChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of second sportsmen: ");
            secondChoice = Convert.ToInt32(Console.ReadLine());

            if (comparer.Compare(Storage[firstChoice], 
                Storage[secondChoice]) == 1)
            {
                Console.WriteLine("First sportsman is more " +
                    "experienced than the second one");
            }
            else if(comparer.Compare(Storage[firstChoice],
                Storage[secondChoice]) == 0)
            {
                Console.WriteLine("First sportsman is less " +
                    "experienced than the second one");
            }
            else
            {
                Console.WriteLine("Both sportsmen are " +
                    "well experienced");
            }
        }

        static void ShowAllForms()
        {
            for (int i = 0; i < Storage.Count; i++)
            {
                Console.WriteLine("[{0}]\n", i + 1);

                Storage[i].PrintData();

                Console.WriteLine("\n");
            }

            ChangeDelete();
        }

        private static void CloneSportsmen()
        {
            int choice;

            Console.WriteLine("Enter number of sportsman " +
                "you whant to be cloned");
            choice = Convert.ToInt32(Console.ReadLine());

            Storage.Add((Speciality)Storage[choice].Clone());
        }

        static int Menu()
        {
            string way;

            Console.WriteLine("1.Add Sportsmen\n2.Show all\n" +
                "3.Compare\n0.Exit");

            way = Console.ReadLine();

            Console.Clear();

            if (way == "0")
            {
                return 0;
            }
            else if (way == "1")
            {
                AddSportsmen();
            }
            else if (way == "2")
            {
                ShowAllForms();
            }
            else if (way == "3")
            {
                CompareSportsmen();
            }
            else if (way == "4")
            {
                CloneSportsmen();
            }
            else
            {
                Menu();
            }

            return 0;
        }
    }
}