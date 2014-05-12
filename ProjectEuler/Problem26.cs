using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjectEuler
{
    class Problem26
    {
        // this solution borrows heavily from solutions proposed by others
        public string Run()
        {
            int max = 0;
            int maxCycleLen = 0;
            List<int> remainders;
            for (int i = 983; i < 1000; i++)
            {
                int r = 10, count;
                remainders = new List<int>();
                for (count = 0; !remainders.Contains(r); count++)
                {
                    remainders.Add(r);
                    r = 10 * (r % i);
                }
                int cycleLen = count - remainders.LastIndexOf(r);
                if (cycleLen > maxCycleLen)
                {
                    maxCycleLen = cycleLen;
                    max = i;
                }
            }
            return max.ToString();
        }

        // this is what I came up with on my own and fruitlessly tried to optimize - it runs in a bit under 2 minutes
        #region original
        BigInteger bigNum = BigInteger.Pow(100000000, 1000);
        int maxCycleLength = 0;
        object _lock = new object();

        public string OldRun()
        {
            int num = 0;
            foreach (int i in SequenceHelper.GeneratePrimes().TakeWhile(i=>i<1000).Reverse())
            {
                if (i < maxCycleLength) break;
                int iCycleLength = GetMaxCycle((bigNum / i).ToString())
                    .Length;
                if (iCycleLength > maxCycleLength)
                {
                    num = i;
                    maxCycleLength = iCycleLength;
                }
                Console.WriteLine(i);
            }
            return num.ToString();
        }

        public string GetMaxCycle(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j < (s.Length - i) / 2; j++)
                {
                    string cycle = s.Substring(i, j);
                    int matches = Regex.Matches(s, cycle).Count;
                    if (matches == 1) break;
                    if (matches * j == s.Length - i)
                    {
                        return cycle;
                    }
                }
            }
            return "";
        }

        #endregion
    }
}
