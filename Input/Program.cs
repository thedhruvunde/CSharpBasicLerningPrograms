using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer> ");
            int a = Convert.ToInt32(Console.ReadLine()); //integer input!?
            Console.WriteLine(a);
            Console.Write("Input a decimal number> ");
            decimal b = Convert.ToDecimal(Console.ReadLine()); //decimal input
            Console.WriteLine(b);
            Console.Write("Input a string> ");
            string c = Console.ReadLine(); //string input
            Console.WriteLine(c);
            Console.Write("Input a boolean> ");
            bool d = Convert.ToBoolean(Console.ReadLine()); //boolean input
            Console.WriteLine(d);
        }
    }
}