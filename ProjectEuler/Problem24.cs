using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem24
    {
        public string Run()
        {
            return GeneratePermutations("", "9876543210")
                .Select(s => long.Parse(s)).OrderBy(i => i)
                .ElementAt(999999).ToString();
        }

        public IEnumerable<string> GeneratePermutations(string a, string b)
        {
            if (b.Length == 0) yield return a;
            else
            {
                for (int i = 0; i < b.Length; i++)
                {
                    foreach (string s in GeneratePermutations(a+b[i], b.Substring(0,i) + b.Substring(i+1)))
                    {
                        yield return s;
                    }
                }
            }
        }
    }
}
