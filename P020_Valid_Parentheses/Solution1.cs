using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P020_Valid_Parentheses
{
    public static class Solution1
    {
        public static bool IsValid(string s)
        {
            if (s == null)
                return true;

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c == ' ')
                {
                    continue;
                }

                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char topelement =  stack.Pop();
                    char matched = '#';

                    if (c == ')')
                    {
                        matched = '(';
                    }
                    else if(c == ']')
                    {
                        matched = '[';
                    }
                    else if (c == '}')
                    {
                        matched = '{';
                    }

                    if (topelement != matched)
                    {
                        return false;
                    }
                }

            }

            return stack.Count == 0;
        }


    }
}
