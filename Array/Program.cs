using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = {"apple", "banana", "pear", "pineapple", "strawberry"}; //we have created a string array
            for (int i=0; i<fruits.Length; i++) //creating a for loop
            {
                Console.WriteLine(i+1 + "." + fruits[i]); //writing elements in that array as they are ranked
            }

            string[] movies = new string[5]; //we have created an empty string array
            Console.WriteLine("Tell Your Top 5 favorite movies");
            for (int j = 1; j<= movies.Length; j++) //for loop for adding elements in array
            {
                Console.Write("Enter movie number  "+ j + "> ");
                movies[j-1] = Console.ReadLine();
            }
            Console.WriteLine("Your Top movies are:");
            for (int m=0; m<fruits.Length; m++) //creating a for loop
            {
                Console.WriteLine(m+1 + "." + movies[m]); //writing elements in that array as they are ranked
            }

        }
    }
}
