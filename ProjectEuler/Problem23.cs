using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem23
    {
        const int LIMIT = 28123;
        public string Run()
        {
            var abundantNumbers = SequenceHelper.GenerateAbundantNumbers().TakeWhile(i => i <= LIMIT).ToList();
            var abundantSums = new HashSet<int>(
                abundantNumbers.AsParallel().Select(a => abundantNumbers.Select(b => a + b)).SelectMany(i => i)
                );
            return SequenceHelper.GenerateSequence(1).TakeWhile(i => i <= LIMIT)
                .Where(i => !abundantSums.Contains(i)).Sum().ToString();
        }
    }
}
