using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice
{
    class Dict_FrequencyQueries
    {
        public List<int> freqQuery(List<List<int>> queries)
        {
            var retVal = new List<int>();
            Dictionary<int, int> elemetsDict = new Dictionary<int, int>();
            Dictionary<int, HashSet<int>> counterDict = new Dictionary<int, HashSet<int>>();

            foreach (List<int> inner in queries)
            {
                int command = inner[0];
                int val = inner[1];

                if (command == 1)
                {
                    if (elemetsDict.ContainsKey(val) && elemetsDict[val] > 0)
                    {
                        var eleCount = elemetsDict[val]++ + 1;
                        if (counterDict.ContainsKey(eleCount - 1))
                        {
                            RemovePreCount(eleCount - 1, val, ref counterDict);
                            AddCount(eleCount, val, ref counterDict);
                        }
                        else
                            AddCount(eleCount, val, ref counterDict);
                    }
                    else
                    {
                        elemetsDict[val] = 1;
                        AddCount(1, val, ref counterDict);
                    }
                }
                if (command == 2)
                    if (elemetsDict.ContainsKey(val))
                    {
                        
                        RemovePreCount(elemetsDict[val], val, ref counterDict);
                        elemetsDict[val]--;
                        if (elemetsDict[val] == 0)
                            elemetsDict.Remove(val);
                        else
                            AddCount(elemetsDict[val], val, ref counterDict);
                    }

                if (command == 3)
                    if (counterDict.ContainsKey(val))
                        retVal.Add(1);
                    else
                        retVal.Add(0);
            }
            return retVal;
        }

         void AddCount(int eleCount, int val, ref Dictionary<int, HashSet<int>> counterDict)
        {
            if (counterDict.ContainsKey(eleCount))
                counterDict[eleCount].Add(val);
            else
                counterDict.Add(eleCount, new HashSet<int>() { val });
        }

         void RemovePreCount(int preCount, int val, ref Dictionary<int, HashSet<int>> counterDict)
        {
            if (counterDict.ContainsKey(preCount))
            {
                counterDict[preCount].Remove(val);
            }

        }
    }
}
