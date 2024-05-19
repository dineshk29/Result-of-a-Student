
using System;
using System.Numerics;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, rollno;
            int s1, s2, s3, s4, s5, Total;
            Console.WriteLine("         III-I SEM RESULTS            ");
            Console.Write("NAME    : ");
            name = Console.ReadLine();
            Console.Write("ROLLNO  : ");
            rollno = Console.ReadLine();
            Console.WriteLine("         MARKS LIST            ");
            Console.WriteLine("       ==============         ");
            Console.Write("maths4                   : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("data analytics           : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("machine learning         : ");
            s3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("artificial intelligencse : ");
            s4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("computer networks        : ");
            s5 = Convert.ToInt32(Console.ReadLine());
            Total = (s1 + s2 + s3 + s4 + s5);
            Console.WriteLine("Total Marks: " + Total);
            Console.WriteLine("Total Percentage: " + (Total / 500.0) * 100 + "%");

        }
    }
}