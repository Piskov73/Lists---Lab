using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersProdukts=int.Parse(Console.ReadLine());
            List<string> listOfProducts=new List<string>();
            for (int i = 0; i < numbersProdukts; i++)
            {
                listOfProducts.Add(Console.ReadLine());
            }
            listOfProducts.Sort();
            int count = 1;
            foreach (var nameProdukt in listOfProducts)
            {
                Console.WriteLine($"{count}.{nameProdukt}");
                count++;
            }
        }
    }
}
