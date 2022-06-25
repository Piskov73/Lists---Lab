using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 	Add { number}: add a number to the end of the list.
            //•	Remove { number}: remove a number from the list.
            //•	RemoveAt { index}: remove a number at a given index.
            //•	Insert { number}  { index}: insert a number at a given index.
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (comand[0] != "end")
            {
                if (comand[0] == "Add")
                {
                    numbers.Add(int.Parse(comand[1]));
                }
                else if (comand[0] == "Remove")
                {
                    numbers.Remove(int.Parse(comand[1]));
                }
                else if (comand[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(comand[1]));
                }
                else if (comand[0] == "Insert")
                {
                    numbers.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                }
                comand= Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(String.Join(" ",numbers));


        }
    }
}
