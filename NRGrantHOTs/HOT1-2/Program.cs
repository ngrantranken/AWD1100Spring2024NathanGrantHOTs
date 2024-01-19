using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

namespace HOT1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Please enter the first decimal:\t");
            double dec1 = double.Parse(Console.ReadLine());
            Write("Please enter the second decimal:\t");
            double dec2 = double.Parse(Console.ReadLine());
            Write("Please enter the third decimal:\t");
            double dec3 = double.Parse(Console.ReadLine());
            double sum = dec1 + dec2 + dec3;
            double average = sum / 3;
            Write("The average of your 3 numbers is: " + average);
        }
    }
}