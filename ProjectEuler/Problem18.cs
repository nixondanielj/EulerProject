using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem18
    {
        public string Run()
        {
            var triangle = ParseGiven();
            for (int y = 1; y < triangle.Length; y++)
            {
                for (int x = 0; x < triangle[y].Length; x++)
                {
                    // get each node if it exists, else 0
                    int rightNode = x < triangle[y-1].Length ? triangle[y-1][x] : 0;
                    int leftNode = x > 0 ? triangle[y-1][x-1] : 0;
                    // add the larger of the nodes
                    triangle[y][x] += rightNode > leftNode ? rightNode : leftNode;
                }
            }
            return triangle.Last().Max().ToString();
        }

        public int[][] ParseGiven()
        {
            var lines = given.Split('\n').Select(line => new String(
                    line.Where(c => char.IsDigit(c)).ToArray()
                    )).ToArray();
            int[][] triangle = new int[lines.Length][];
            for (int y = 0; y < lines.Length; y++)
            {
                triangle[y] = new int[lines[y].Length / 2];
                for (int x = 0; x < triangle[y].Length; x++)
                {
                    triangle[y][x] = int.Parse(lines[y].Substring(x*2, 2));
                }
            }
            return triangle;
        }

        string given = @"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
    }
}
