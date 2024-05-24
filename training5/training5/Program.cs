using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 10 numbers each in a line:");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
                else if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine("min is " + min.ToString() + " max is " + max.ToString());
            Console.ReadKey();
        }
    }
}
