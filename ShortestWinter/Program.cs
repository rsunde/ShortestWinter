using System;
using System.Collections.Generic;

namespace ShortestWinter
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Solution(int[] temperatures)
        {
            var winter = new List<int>();
            var warmestWinter = 0;

            foreach (var temp in temperatures)
            {
                if (winter.Count == 0)
                {
                    winter.Add(temp);
                    warmestWinter = temp;

                    continue; // continue on the next item in temperatures
                }

                if (temp <= warmestWinter)
                {
                    winter.Add(temp);
                }
            }

            return winter.Count;
        }
    }
}
