using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using static System.Console;

namespace HOT1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Please enter your name:\t");
            string yourName = ReadLine();
            Write("Street address:\t");
            string address = ReadLine();
            Write("City:\t");
            string city = ReadLine();
            Write("State:\t");
            string state = ReadLine();
            Write("Zip:\t");
            string zip = ReadLine();
            Write("How many T-Shirts did you want to order?\t");
            int quantity = int.Parse(ReadLine());

            double cost = 14.99;
            const double tax = 0.08;
            double total = 14.99 * quantity;
            double taxDue = total * tax;
            double due = total + taxDue;

            string outputStr = $"\n\nReciept for:\n{yourName}\n{address}\n{city}, {state} {zip}\n\n{quantity} T-Shirts ordered at ${cost} each\n\nTotal:\t${total:0.00}\nTax:\t${taxDue:0.00}\n------------------\nDue:\t${due:0.00}";
            Write(outputStr);
        }
    }
}