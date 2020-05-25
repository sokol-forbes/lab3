using System;
using System.Runtime.InteropServices;

namespace MathClient
{
    class Program
    {
        const string str = "D:\\Programming\\VisualStudio\\C#\\Новая папка\\MathLibrary\\Debug\\MathLibrary.dll";
        [DllImport(str, CallingConvention = CallingConvention.StdCall)]
        public static extern int Hello();

        [DllImport("D:\\Programming\\VisualStudio\\C#\\Новая папка\\MathLibrary\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int sum();

        [DllImport("D:\\Programming\\VisualStudio\\C#\\Новая папка\\MathLibrary\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int difference();

        [DllImport("D:\\Programming\\VisualStudio\\C#\\Новая папка\\MathLibrary\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int multiplication();

        [DllImport("D:\\Programming\\VisualStudio\\C#\\Новая папка\\MathLibrary\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double average();

        [DllImport("D:\\Programming\\VisualStudio\\C#\\Новая папка\\MathLibrary\\Debug\\MathLibrary.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double division();

        static void Main(string[] args)
        {
            int a;
            a = 0;

            Hello();

            for (; ;)
            {
                Console.WriteLine("Choose one function:\n1)sum;\n2)difference;" +
                    "\n3)multiplication;\n4)division;\n5)Average number;\n6)EXIT;");

                a = int.Parse(Console.ReadLine());

                if (a == 6)
                {
                    Console.WriteLine("Program exit");
                    break;
                }
                else
                {
                    switch (a)
                    {
                        case 1:
                            {
                                Console.WriteLine(sum());
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine(difference());
                                break;
                            }
                        case 3:
                            { 
                                Console.WriteLine(multiplication()); 
                                break; 
                            }
                        case 4: 
                            { 
                                Console.WriteLine(division()); 
                                break; 
                            }
                        case 5:
                            {
                                Console.WriteLine(average()); 
                                break;
                            }
                    }

                    Console.WriteLine("Done successfully");
                }
            }
        }
    }
}
