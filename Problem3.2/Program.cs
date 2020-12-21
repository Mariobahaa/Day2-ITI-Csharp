using System;
using System.Diagnostics;

namespace Problem3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int cnt = 0;
            for (int i = 1; i <= 99_999_999; i++)
            {
                int val = i;
                while(val>0)
                {
                    if(val%10==1) { cnt++;  }
                    val /= 10;
                }
            }
            stopwatch.Stop();
            Console.WriteLine(cnt);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
