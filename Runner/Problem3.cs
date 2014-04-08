using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem3
    {
        long number = 600851475143;
        public string Run()
        {
            int max = 0;
            for(int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)// && IsPrime(i))
                {
                    max = i;
                }
            }
            return max.ToString();
        }
    }
}
