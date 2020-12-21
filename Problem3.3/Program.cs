using System;
using System.Diagnostics;

namespace Problem3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            float dig = 0;
            int num = 999_999_99;
            int n = num;
            while(num>0)
            {
                dig++;
                num /= 10;

            }
 
            stopwatch.Stop();
            Console.WriteLine(Math.Ceiling((dig/10.0)*n));
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
