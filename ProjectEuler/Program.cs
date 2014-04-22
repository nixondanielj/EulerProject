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
        static Dictionary<string, string> tests = new Dictionary<string, string>()
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
            {"17", "21124"}
        };
        public static void Main(string[] args)
        {
            while (true)
            {
                string puzzleName = string.Format("Problem{0}",
                    PromptForInt("Enter the problem number:"));
                if (puzzleName == "Problem0")
                {
                    RunTests();
                }
                else
                {
                    ExecuteProblem(puzzleName);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
        }

        private static void ExecuteProblem(string puzzleName)
        {
            var stopwatch = new Stopwatch();
            var obj = GetObjectSafely(puzzleName);
            if (obj != null)
            {
                stopwatch.Start();
                Console.WriteLine("Result: {0}",
                    obj.GetType().GetMethod("Run").Invoke(obj, null));
                stopwatch.Stop();
                Console.WriteLine("Took {0} seconds", stopwatch.Elapsed.TotalSeconds);
                stopwatch.Reset();
            }
            else
            {
                Console.WriteLine("{0} was not a valid puzzle", puzzleName);
            }
        }

        private static void RunTests()
        {
            foreach (var pair in tests)
            {
                var obj = GetObjectSafely(
                    string.Format("Problem{0}", pair.Key)
                    );
                if (obj.GetType().GetMethod("Run").Invoke(obj, null).ToString() == pair.Value)
                {
                    Console.WriteLine("Problem {0} passed", pair.Key);
                }
                else
                {
                    Console.WriteLine("Problem {0} failed", pair.Key);
                }
            }
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
            catch (Exception e)
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
}
