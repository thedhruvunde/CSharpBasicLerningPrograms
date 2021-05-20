using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "strawberry";
            if (a == "banana"){
                Console.WriteLine("We have an banana here!");
            }
            else if(a != "apple"){
                Console.WriteLine("We don't have an apple here!");
                Console.WriteLine("We have " + a); 
            }
            else{
                Console.WriteLine("Ohh! there's nothing here");
            }
        }
    }
}
