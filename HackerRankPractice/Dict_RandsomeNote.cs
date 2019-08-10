using System;
using System.Collections.Generic;

namespace HackerRankPractice
{
    class Dict_RandsomeNote
    {

        public void checkMagazine(string[] magazine, string[] note)
        {
            if (magazine.Length == 0)
                Console.WriteLine("No");

            Dictionary<string, int> magazineWords = new Dictionary<string, int>();
            foreach (string s in magazine)
            {
                if (magazineWords.ContainsKey(s))
                    magazineWords[s] = magazineWords[s] + 1;
                else
                    magazineWords.Add(s, 1);
            }

            bool done = false;
            foreach (string s in note)
            {
                if (magazineWords.ContainsKey(s))
                    if (magazineWords[s] > 0)
                    {
                        magazineWords[s] = magazineWords[s] - 1;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No");
                        done = true;
                        break;
                    }
                Console.WriteLine("No");
                done = true;
                break;
            }
            if(!done)
            Console.WriteLine("Yes");

        }


    }
}
