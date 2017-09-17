using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalc
{
	public class Calc
	{
		public Calc()
		{
		}
		public Boolean Check(string input)
		{
			return true;
		}

		public string Parse(string input)
		{
			Stack<string> stack = new Stack<string>();
			int inpLen = input.Length;
			char[] charArray = new char[inpLen];
			int charCount = 0;
			List<string> polandRecord = new List<string>();

			bool end = false;
		StringBuilder operand = new StringBuilder();
					 while(!end)
					{
				if (Char.IsDigit(charArray[charCount])
				{
					while (Char.IsDigit(charArray[charCount])
					{
						operand.Append(charArray[charCount]);
						charCount++;
					}
					       polandRecord.Add(operand.ToString());
				}
					       if (Operations.IsOperation(charArray[charCount]) )
				{ }
//					       parenthesis
						
							charCount +=1 ;
					}

			stack.Push("first");
			string sec = stack.Pop();
			Console.WriteLine(sec);
			return input;
		}

	}


	class Operations
	{
						char[] operationList = {'+','-','*','\\'};
		
						static bool IsParenthesis(char symbol)
		{
			return true;
		}

						static public bool IsOperation(char symbol)
		{
			bool contains =false;   // 
			if (operationList != null)
			{
				foreach (var c in operationList)
				{
					if (c == symbol)
					{
						contains = true;
						break;
					}

					if (                )
					{ }
					return true;
				}
			}
			return true;

		}
}
