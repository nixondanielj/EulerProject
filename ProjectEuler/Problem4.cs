using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem4
    {
        public string Run()
        {
            int max = 0;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    int product = i * j;
                    if (product > max && IsPalindrome(product))
                    {
                        max = product;
                    }
                }
            }
            return max.ToString();
        }

        public bool IsPalindrome(int n)
        {
            return n.ToString() == new string(n.ToString().Reverse().ToArray());
        }
    }
}
