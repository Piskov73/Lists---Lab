

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> input=Console.ReadLine().
                Split(' ',StringSplitOptions.RemoveEmptyEntries).
                Select(double.Parse).ToList();
            Console.WriteLine(String.Join(" ",GaussTrick(input)));
                     
        }
        static List<double> GaussTrick(List<double> input)
        {
            List<double> gaussTrick = new List<double>();
            for (int i = 0; i < input.Count / 2; i++)
            {
                double sum = input[i] + input[input.Count - 1 - i];
                gaussTrick.Add(sum);
            }

            if (input.Count % 2 != 0)
            {
                gaussTrick.Add(input[input.Count / 2]);
            }
            return gaussTrick;
        }
    }
}
