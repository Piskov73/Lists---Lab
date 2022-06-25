using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            bool printList = false;
            while (comand[0] != "end")
            {
                if (comand[0] == "Add")
                {
                    numbers = AddNumber(int.Parse(comand[1]), numbers);
                    printList = true;
                }
                else if (comand[0] == "Remove")
                {
                    numbers = RemoveNumber(int.Parse(comand[1]), numbers);
                    printList = true;
                }
                else if (comand[0] == "RemoveAt")
                {
                    numbers = RemoveIndex(int.Parse(comand[1]), numbers);
                    printList = true;
                }
                else if (comand[0] == "Insert")
                {
                    numbers = InsertIndexNumber(int.Parse(comand[2]), int.Parse(comand[1]), numbers);
                    printList = true;
                }
                else if (comand[0] == "Contains")
                {
                    ConteinsNumber(int.Parse(comand[1]), numbers);
                }
                else if (comand[0] == "PrintEven")
                {
                    PrintEven(numbers);
                }
                else if (comand[0] == "PrintOdd")
                {
                    PrintOdd(numbers);
                }
                else if(comand[0]== "GetSum")
                {
                    Console.WriteLine(GetSum(numbers));
                }
                //•	Filter { condition} { number} – print all the numbers that fulfill the given condition.
                //The condition will be either '<', '>', ">=", "<=".
                else if (comand[0]== "Filter")
                {
                    Filter(comand[1], int.Parse(comand[2]), numbers);
                }
                comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            if (printList)
            {
                Console.WriteLine(String.Join(" ", numbers));

            }

        }
        static List<int> AddNumber(int numb, List<int> input)
        {
            input.Add(numb);
            return input;
        }
        static List<int> RemoveNumber(int numb, List<int> input)
        {
            input.Remove(numb);
            return input;
        }
        static List<int> RemoveIndex(int numb, List<int> input)
        {
            input.RemoveAt(numb);
            return input;
        }
        static List<int> InsertIndexNumber(int index, int numb, List<int> input)
        {
            input.Insert(index, numb);
            return input;
        }
        static void ConteinsNumber(int numb, List<int> input)
        {
            if (input.Contains(numb))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<int> input)
        {
            List<int> print = new List<int>();
            foreach (var numb in input)
            {
                if (numb % 2 == 0)
                {
                    print.Add(numb);
                }
            }
            Console.WriteLine(String.Join(" ", print));
        }
        static void PrintOdd(List<int> input)
        {
            List<int> print = new List<int>();
            foreach (var numb in input)
            {
                if (numb % 2 != 0)
                {
                    print.Add(numb);
                }
            }
            Console.WriteLine(String.Join(" ", print));
        }
        static int GetSum (List <int> input)
        {
            int sum = input.Sum();
            return sum;
        }      
        static void Filter(string condition,int number, List<int> input)
        {
            List<int> print = new List<int>();
            if (condition == "<")
            {
                print = input.FindAll(x => x < number);
            }
            else if(condition==">")
            {
                print = input.FindAll(x => x > number);
            }
            else if (condition == ">=")
            {
                print = input.FindAll(x => x >= number);
            }
            else if (condition == "<=")
            {
                print = input.FindAll(x => x <= number);
            }
            Console.WriteLine(String.Join(" ",print));
        }

    }
}
