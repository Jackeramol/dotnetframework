using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// develop a c# program that find a largest element in a integer array using a loop and if else statement.
namespace Assignment1_Ques03
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
            int large = arr[0];
            for(int i = 1; i < n; i++)
            {
                if (arr[i]>large)
                {
                    large = arr[i];
                }
            }
            Console.WriteLine(large);
        }
    }
}
