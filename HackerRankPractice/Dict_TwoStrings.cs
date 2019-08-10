using System.Collections.Generic;

namespace HackerRankPractice
{
    class Dict_TwoStrings
    {
        public string twoStrings(string s1, string s2)
        {
            string isSubstringContains ="NO";
            Dictionary<char, int> s1Dict = new Dictionary<char, int>();
            foreach (char c in s1.ToCharArray())
            {
                if (s1Dict.ContainsKey(c))
                    s1Dict[c]++;
                else
                    s1Dict.Add(c, 1);
            }


            foreach (char c in s2.ToCharArray())
            {
                if (s1Dict.ContainsKey(c))
                {
                    isSubstringContains = "YES";
                    break;
                }

            }

                return isSubstringContains;
        }
    }
}
