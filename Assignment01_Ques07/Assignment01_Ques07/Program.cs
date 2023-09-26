using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that search for a specified value in an integer array using a loop and return its index if found
namespace Assignment01_Ques07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 10 };
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (n == arr[i])
                {
                    Console.WriteLine("index value of the integer is :- " + i);
                    System.Environment.Exit(0);
                }
            }
            Console.WriteLine("Element not found");
        }
    }
}
  