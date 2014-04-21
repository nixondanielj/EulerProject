using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem14
    {
        public string Run()
        {
            // the code I used below is completely opaque, so here's some pseudocode to show what's going on:
            // for i in 1..1000000
            //     if collatz(i).count > collatz(best).count
            //         best = i
            // return best
            return Enumerable.Range(1,999999)
                .Aggregate((a, b) =>
                    GetCollatzCount(a) > GetCollatzCount(b) ? a : b).ToString();
        }

        Dictionary<int, int> collatzMem = new Dictionary<int, int>();

        int GetCollatzCount(int i)
        {
            if (!collatzMem.ContainsKey(i))
            {
                collatzMem[i] = SequenceHelper.GenerateCollatzSequence(i).Count();
            }
            return collatzMem[i];
        }
    }
}
