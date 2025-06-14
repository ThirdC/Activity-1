using System;

namespace FunctionDemo
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Eduardo A. Cariño III");
            Console.WriteLine("BSIT 3-4");
            Console.WriteLine("Activity 1");
            Console.WriteLine("Application Development and Emerging Technologies");
            Console.WriteLine("C# Function Add, Subtract, Multiply, and Divide");

            Console.Write("Enter first number: ");
            int fn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number: ");
            int sn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine($"Add: {Add(fn, sn)}");
            Console.WriteLine($"Subtract: {Sub(fn, sn)}");
            Console.WriteLine($"Multiply: {Mul(fn, sn)}");
            Console.WriteLine($"Divide: {Div(fn, sn)}");

            // Added Function
            CompareNumbers(fn, sn);
        }
        
        static void CompareNumbers(int fn, int sn)
        {
            if (fn > sn)
                Console.WriteLine($"{fn} is greater than {sn}");
            else if (fn < sn)
                Console.WriteLine($"{fn} is less than {sn}");
            else
                Console.WriteLine($"{fn} is equal to {sn}");
        }

        static int Add(int fn, int sn) => fn + sn;
        static int Sub(int fn, int sn) => fn - sn;
        static int Mul(int fn, int sn) => fn * sn;
        static double Div(int fn, int sn) => sn != 0 ? (double)fn / sn : 0;
    }
}


