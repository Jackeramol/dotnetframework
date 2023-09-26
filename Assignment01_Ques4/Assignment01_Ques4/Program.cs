using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a c# program that count the even and odd elememnt of an integer array using loop and if else statement
namespace Assignment01_Ques4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count_even = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count_even++;
                }

            }
            int count_odd = n - count_even;
            Console.WriteLine("number of even element in the array is :- " + count_even);
            Console.WriteLine("Number of odd element in the array is :- " + count_odd);

        }
    }
}
