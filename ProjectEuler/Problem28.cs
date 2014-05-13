using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem28
    {
        public string Run()
        {
            List<int> diagonals = new List<int>(){ 1 };
            int skipped = 0;
            for (int i = 3; diagonals.Count < 2001; i+=2)
            {
                int toSkip = (diagonals.Count - 1) / 4;
                if (skipped == toSkip)
                {
                    skipped = 0;
                    diagonals.Add(i);
                }
                else
                {
                    skipped++;
                }
            }
            return diagonals.Sum().ToString();
        }
    }
}
