using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalc
{
    public class Calc : ICalc
    {
        IOperations Operations;
        public Calc(IOperations Operations)
        {
            this.Operations = Operations; // class Operations will form constructor and may have any realisation in according IOperations interface
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
            while (!end)
            {
                if (Char.IsDigit(charArray[charCount]))
                {
                    while (Char.IsDigit(charArray[charCount]))
                    {
                        operand.Append(charArray[charCount]);
                        charCount++;
                    }
                    polandRecord.Add(operand.ToString());
                }
                if (Operations.IsOperation(charArray[charCount]))
                { }
                //					       parenthesis

                charCount += 1;
            }

            stack.Push("first");
            string sec = stack.Pop();
            Console.WriteLine(sec);
            return input;
        }

    }


}