using System;

namespace DataWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                {11,25,35,41,54},
                {10,52,93,18,66},
                {15,23,63,42,77},
                {47,31,21,14,22},
                {47,31,21,14,22}

            };
            int limit = int.Parse(Console.ReadLine());
            int limit1 = int.Parse(Console.ReadLine());
            int limit2 = int.Parse(Console.ReadLine());
            int limit3 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                //int one = array[i, 0];
                //int two = array[i, 1];
                //int three = array[i, 2];
                //int four = array[i, 3];

                Console.WriteLine("{0} {1} {2} {3}", limit, limit1, limit2, limit3);
            }
        }
    }
}
