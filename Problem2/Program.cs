using System;
using System.Text;


namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            String str = Console.ReadLine();
            String[] arr = str.Split();
            StringBuilder sb = new StringBuilder("", arr.Length);
            for (int i=arr.Length-1;i>=0;i--)
            {
                sb.Append(arr[i]);
                sb.Append(' ');
                
            }
            Console.WriteLine(sb);
        }
    }
}
