using System;
using BubbleSort;

namespace FUsing
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] array = new int[]{5,27,96,62,547,23,654,123,5,4,2,64,53,5123};
            int[] res = BubbleSort.ShareSort.sort(array);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
    }
}