using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        public static Dictionary<string, string> tests = new Dictionary<string, string>()
        {
            {"1", "233168"},
            {"2","4613732"},
            {"3", "6857"},
            {"4", "906609"},
            {"5", "232792560"},
            {"6", "25164150"},
            {"7", "104743"},
            {"8", "40824"},
            {"9", "31875000"},
            {"10", "142913828922"},
            {"11", "70600674"},
            {"12", "76576500"},
            {"13", "5537376230"},
            {"14", "837799"},
            {"15", "137846528820"},
            {"16", "1366"},
            {"17", "21124"},
            {"18", "1074"},
            {"19", "171"},
            {"20", "648"},
            {"21", "31626"},
            {"22", "871198282"},
            {"23", "4179871"},
            {"24", "2783915460"}
        };
        public static void Main(string[] args)
        {
            new Problem24().Run();
            while (true)
            {
                int problem = PromptForInt("Enter a problem number or 0 for testing:");
                if (problem == 0)
                {
                    RunTests();
                }
                else
                {
                    PrintResult(ExecuteProblem(problem));
                }
            }
        }

        private static void RunTests()
        {
            foreach (var pair in tests)
            {
                Result result = ExecuteProblem(int.Parse(pair.Key));
                string passOrFail = result.Value == pair.Value ? "passed" : "failed";
                PrintResult(result, passOrFail);
            }
        }

        private static void PrintResult(Result result, string passOrFail = "untested")
        {
            Console.WriteLine("Problem {0} {1} with: {2} in {3} seconds",
                    result.Problem, passOrFail, result.Value, result.Time);
        }

        private static double TimeForSeconds(Action action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalSeconds;
        }

        private static Result ExecuteProblem(int number)
        {
            Result result = new Result() { Problem = number };
            var obj = GetObjectSafely(string.Format("Problem{0}", number));
            if (obj != null)
            {
                result.Time = TimeForSeconds(
                    () => result.Value = obj.GetType().GetMethod("Run").Invoke(obj, null).ToString()
                    );
            }
            return result;
        }

        private static object GetObjectSafely(string puzzle)
        {
            object objHandle;
            try
            {
                objHandle = Activator.
                    CreateInstance(null, string.Format("ProjectEuler.{0}", puzzle))
                    .Unwrap();
            }
            catch (Exception)
            {
                objHandle = null;
            }
            return objHandle;
        }

        public static int PromptForInt(string message)
        {
            string input = "";
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            return result;
        }
    }

    class Result
    {
        public int Problem { get; set; }
        public double Time { get; set; }
        public string Value { get; set; }
    }
}
