using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            while (true)
            {
                string puzzleName = string.Format("Problem{0}",
                    PromptForInt("Enter the problem number:"));
                var objHandle = GetPuzzleSafely(puzzleName);
                if (objHandle != null)
                {
                    stopwatch.Start();
                    Console.WriteLine("Result: {0}",
                        objHandle.GetType().GetMethod("Run").Invoke(objHandle, null));
                    stopwatch.Stop();
                    Console.WriteLine("Took {0} seconds", stopwatch.Elapsed.TotalSeconds);
                    stopwatch.Reset();
                }
                else
                {
                    Console.WriteLine("{0} was not a valid puzzle", puzzleName);
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }

        private static object GetPuzzleSafely(string puzzle)
        {
            object objHandle;
            try
            {
                objHandle = Activator.CreateInstance("Runner", puzzle);
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
            }
            return result;
        }
    }
}
