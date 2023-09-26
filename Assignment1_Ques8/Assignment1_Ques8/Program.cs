using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// develop a c# program that second smallest element in an integer array using loop and sorting technique.
namespace Assignment1_Ques8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 11, 4, 5, 6, 20, 3 };
            Array.Sort(arr);
            int small = -1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] !=arr[i - 1])
                {
                    small = arr[i];
                    break;
                }
            }
            if (small != -1)
            {
                Console.WriteLine(small);
            }
            else
            {
                Console.WriteLine("not ");
            }
        }
    }
}
