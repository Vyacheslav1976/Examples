using System;
//using Calc;

namespace StringCalc
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please, type exercise!");
			String input = Console.ReadLine();
			ICalc calc = new Calc();
			if (calc.Check(input))
			{
				calc.Parse(input);

			};
			Console.WriteLine("Input = "+input);
			Console.ReadKey();

		}
	}
}
