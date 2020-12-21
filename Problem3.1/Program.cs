using System;
using System.Diagnostics;

namespace Problem3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int cnt = 0;
            for(int i=1;i<=99_999_999;i++)
            {
                String str = i.ToString();
                for(int j=0;j<str.Length;j++)
                {
                    if (str[j] == '1') cnt++;
                }
            }
            stopwatch.Stop();
            Console.WriteLine(cnt);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
