using System;

namespace Functions
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                int num = takeCommand();
                int result = squareTheNum(num);
                Console.WriteLine(result);
            }
        }
        static int squareTheNum(int basenum) //this squares squares any integer
        {
            int square = basenum * basenum;
            return square;
        }       

        static int takeCommand() //this function is taking an integer input
        {
            Console.Write("Type an integer> ");
            int inp = Convert.ToInt32(Console.ReadLine());
            return inp;
        } 
    }
}
