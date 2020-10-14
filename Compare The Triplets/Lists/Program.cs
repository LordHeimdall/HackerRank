using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int> //declaring our result List and initializing score for Alice result[0] and Bob result[1]
            {
                0,
                0
            };
            for (int i = 0; i < a.Count; i++) //Using a.Count in case list size is dynamic in the future
            {
                if (a[i] > b[i]) //If Alice has a higher score than Bob
                {
                    result[0] = result[0] + 1; //Alice gets a point
                }
                else if (a[i] < b[i]) //If Bob has a higher score than Alice
                {
                    result[1] = result[1] + 1; //Bob gets a point
                }
                //If they tie, no one gets points, not necessary to write the a = b case
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 5 }; //Customize your tests here
            int[] arrayb = new int[] { 1, 3, 9 };
            List<int> a = new List<int>(array);
            List<int> b = new List<int>(arrayb);
            List<int> result = compareTriplets(a, b); //calling the method...
            result.ForEach(Console.WriteLine); //printing result
        }
    }
}
