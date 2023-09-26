using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a c sharp program to find the sum of all element in an integer array using a loop */
namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);

        }
    }
}
