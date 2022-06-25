

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();
            numbers = RemNegatAndReverse(numbers);
            if (numbers.Count < 1)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(String.Join(" ",numbers));

          


        }
        static List<int> RemNegatAndReverse(List<int> input)
        {
            input.RemoveAll(x => x < 0);
            input.Reverse();
            return input;
        }
    }
}
