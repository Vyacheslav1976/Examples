using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalc
{
    public class Operations : IOperations
{
    char[] operationList = { '+', '-', '*', '\\' };

    bool IsParenthesis(char symbol)
    {
        return true;
    }

    public bool IsOperation(char oper_symbol)
    {
        bool contains = false;   // 
        if (operationList != null)
        {
            foreach (var c in operationList)
            {
                if (c == oper_symbol)
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
}