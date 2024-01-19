using System;
using static System.Console;

namespace HOT1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Please enter your name:\t");
            string yourName = ReadLine();
            Write("Hello, " + yourName + "!");
        }
    }
}
