using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Implement the c# program that reverse the element in the array using loop
namespace Assigment01_Ques5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
