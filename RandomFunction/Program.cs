using System;
using System.Linq;

namespace RandomFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CreateUnorderedArray();
        }

        public static int[] CreateUnorderedArray()
        {
            int[] arr = new int[1000];
            int[] aux = new int[1000];
            int fixedLength = aux.Length;
            int rndNum = 1;
            int y = 0;
            Random rnd = new Random();

            for (int i = 1; i < 1001; i++) { aux[i - 1] = i; }

            while (arr[arr.Length - 1] == 0)
            {
                rndNum = rnd.Next(1, fixedLength + 1);
                if (aux[rndNum - 1] != 0)
                {
                    arr[y] = aux[rndNum - 1];
                    aux[rndNum - 1] = aux[fixedLength - 1];
                    aux[fixedLength - 1] = 0;
                    fixedLength--;
                    y++;
                }
            }
            return arr;
        }
    }
}
