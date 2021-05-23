using System;

namespace Classes
{
	class ArithematicOperations
	{
		public void SquareIt()
		{
			while (true)
			{
				Console.Write("Type to square> ");
				int inp = Convert.ToInt32(Console.ReadLine());
				int result = inp * inp;
				Console.WriteLine("Square is "+result);
			}
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
            ArithematicOperations num = new ArithematicOperations();
            num.SquareIt();
        }
    }
}
