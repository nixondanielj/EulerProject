using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem25
    {
        public string Run()
        {
            // i+1 in the tuple creation is to adjust for a 0 based index
            return SequenceHelper.GenerateFibonacci().Select((b, i) => Tuple.Create(i + 1, b))
                .First(t => t.Item2.ToString().Length == 1000).Item1.ToString();
        }
    }
}
