using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Numerics;

namespace ProjectEuler
{
    class Problem22
    {
        private const string NAMES_URL = "http://projecteuler.net/project/names.txt";
        private const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
        public string Run()
        {
            return GetNames().Select(s => s.ToLower()).OrderBy(a => a)
                .Select((s, i) => s.Aggregate(0, (n, c) => n += 1 + ALPHABET.IndexOf(c)) * (i + 1))
                .Aggregate(new BigInteger(), (a, b) => a += b).ToString();
        }

        public string[] GetNames()
        {
            using (WebClient client = new WebClient())
            {
                using (var reader = new StreamReader(client.OpenRead(NAMES_URL)))
                {
                    return reader.ReadToEnd().Replace("\"", "").Split(',');
                }
            }
        }
    }
}
