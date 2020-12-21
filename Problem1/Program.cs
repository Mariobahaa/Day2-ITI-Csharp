using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size= int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int max = 0;
            Console.WriteLine("Enter array elements: ");
            for (int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0;i<size;i++)
            {
                int last = i;
                for(int j=i+1;j<size;j++)
                {
                    if (arr[i] == arr[j]) last = j;

                }
                int dist = last - i - 1;
                if (dist > max) max = dist;
            }

            Console.WriteLine($"max distance is: {max}");
        }
    }
}
