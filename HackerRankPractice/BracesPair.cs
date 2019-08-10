using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice
{
    class BracesPair
    {
        public string isBalanced(string s)
        {
            var evaluate = s;
            Stack<char> charStack = new Stack<char>();
            for (int j = 0; j < evaluate.Length; j++)
            {
                if (evaluate[j] == '{' || evaluate[j] == '[' || evaluate[j] == '(')
                    charStack.Push(evaluate[j]);
                else if (evaluate[j] == '}' || evaluate[j] == ']' || evaluate[j] == ')')
                {
                    if (charStack.Count == 0)
                        return "NO";
                    char left = charStack.Pop();
                    char right = evaluate[j];
                    if (AreMatchedPair(left, right))
                        continue;
                    else
                        return "NO";
                }
            }
            if (charStack.Count > 0)
                return "NO";
            return "YES";

        }
        public bool AreMatchedPair(char left, char right)
        {
            if (left == '(' && right == ')')
                return true;
            else if (left == '{' && right == '}')
                return true;
            else if (left == '[' && right == ']')
                return true;
            else
                return false;
        }
    }
}
