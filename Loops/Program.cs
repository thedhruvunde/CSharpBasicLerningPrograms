using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a < 10){
                Console.WriteLine("While loop step: " + a);
                a = a+1;
            }

            for (int i = 1; i < 10; i++){
                Console.WriteLine("For loop step: " + i);
            }
        }
    }
}
