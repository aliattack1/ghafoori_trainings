using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(new int[] {1, 2, 3}));
            Console.WriteLine(sum(new double[] { 1.1, 2.2, 3.3 }));
            Console.ReadKey();


        }

        static int sum(int[] args)
        {
            return args.Sum();
        }
        static double sum(double[] args)
        {
            return args.Sum();
        }
    }
}
