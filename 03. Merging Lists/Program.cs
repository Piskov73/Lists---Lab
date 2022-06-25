using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> firstNumbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List <int> secondNumbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(String.Join(' ',MergingLists(firstNumbers,secondNumbers)));

        }
        static List<int> MergingLists(List<int> first, List<int> second)
        {
            List<int> merigihgLists = new List<int>();
            if (first.Count == second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    merigihgLists.Add(first[i]);
                    merigihgLists.Add(second[i]);
                }
            }
            else if(first.Count < second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    merigihgLists.Add(first[i]);
                    merigihgLists.Add(second[i]);
                }
                for (int i = first.Count; i < second.Count; i++)
                {
                    merigihgLists.Add(second[i]);
                }
            }
            else if(second.Count<first.Count)
            {
                for (int i = 0; i < second.Count; i++)
                {
                    merigihgLists.Add(first[i]);
                    merigihgLists.Add(second[i]);
                }
                for (int i = second.Count; i < first.Count; i++)
                {
                    merigihgLists.Add(first[i]);
                }

            }
            return merigihgLists;      
        }
    }
}
