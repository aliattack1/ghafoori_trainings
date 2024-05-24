using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doubler(new int[]{ 1, 2 , 3});
            
            
            
        }

        static public void doubler(int[] array)
        {
            int[] doubled = new int[array.Length];
            int j = 0;
            foreach (int i in array) 
            {
                doubled[j] = i*2;
                j++;
            }
            foreach (int i in doubled)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
