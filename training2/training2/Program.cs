using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mean();
            Console.ReadLine();
        }

        static public void mean()
        {
            float[][] students = new float[3][];
            for (int i = 0; i < 3; i++) 
            {
                float[] scores = new float[2];
                for(int j = 0; j < 2; j++) 
                {
                    Console.WriteLine("enter number " + (i+1).ToString() + " student number " + (j+1).ToString() + " score");
                    scores[j] = int.Parse(Console.ReadLine());

                }
                students[i] = scores;
            }
            float[] sums = new float[3];
            int z = 0;
            foreach (float[] scores in students) 
            {
                sums[z] = scores.Sum()/2;
                z++;
            }
            Console.WriteLine("student number 1 mean " + sums[0] + " student number 2 mean " + sums[1] + " student number 3 mean " + sums[2]);
        }
    }
}
