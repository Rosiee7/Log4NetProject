using System;
using System.Diagnostics;

namespace Log4NetProject
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Enter a number");

            bool isNumber = int.TryParse(Console.ReadLine(), out num);

            if (isNumber)
            {
                Console.WriteLine("You entered {0}", num);

                // Create new stopwatch.
                Stopwatch stopwatch = new Stopwatch();

                // Begin timing.
                stopwatch.Start();

                // Do something.
                for (int i = 1; i <= num; i++)
                {

                }

                // Stop timing.
                stopwatch.Stop();

                // Write result.
                Console.WriteLine($"Time elapsed: {stopwatch.Elapsed.Milliseconds:0.0} ms");

                log.Info($"Input:{num} – Time: {stopwatch.Elapsed.Milliseconds:0.0} ms");

            }

            else
            {
                Console.WriteLine("Invalid input");
            }


            Console.ReadLine();

        }

    }
}
