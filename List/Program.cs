using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> basket = new List<string>();
            int count = 0;
            Console.WriteLine("Type what we have to add in our basket (Type stop to end)");
            while(true)
            {
                Console.Write(count + "> ");
                string item = Console.ReadLine();

                if (item == "stop"){
                    break;
                }
                else{
                    basket.Add(item);
                    count += 1;
                    continue;
                }
            }
        }
    }
}
