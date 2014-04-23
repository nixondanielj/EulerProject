using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem12
    {
        public string Run()
        {
            return SequenceHelper.GenerateTriangleNumbers()
                .First(i => MathHelper.GetDivisors(i).Count() > 500).ToString();
        }
    }
}
