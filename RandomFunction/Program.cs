using System;

namespace RandomFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UnorderedArray = CreateUnorderedArray();
        }

        public static int[] CreateUnorderedArray()
        {
            int[] randomArray = new int[1000];
            int currNumber;
            int i = 0;

            Random rnd = new Random();

            while (i < 1000)
            {
                currNumber = rnd.Next(1, 1001);
                if (Array.IndexOf(randomArray, currNumber) == -1)
                {
                    randomArray[i] = currNumber;
                    i++;
                }
            }

            return randomArray;
        }
    }
}
