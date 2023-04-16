using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 31, 57, 29, 120, 842, -13, -57, 294 };
            foreach (int value in values) 
            {
                Console.Write(value);
                Console.Write(",");            
            }
            Console.WriteLine("");
            Console.WriteLine(GetMin(values));
        }

        public static int GetMin(params int[] values) 
        {
            int min = int.MaxValue;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            return min;
        }
    }
}
