using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Create a c# program that calculates the average value in a floating point array in a loop
namespace Assignment1_Ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            float sum = 0;
            float[] arr = new float[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = (float)Convert.ToDouble(Console.ReadLine());
                
            }
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];

            }
            float average = sum / n;
            Console.WriteLine(average);
        }
    }
}
