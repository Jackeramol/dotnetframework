using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// create a c# program that multiply each element in an integer array by a specified factor using a loop
namespace Assignment01_Ques06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] *= 2;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
