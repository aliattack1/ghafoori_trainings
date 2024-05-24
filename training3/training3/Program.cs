using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib());
            
            Console.ReadKey();
        }

        static public int fib()
        {
            Console.WriteLine("enter n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 3)
            {
                return 1;
            }
            int a = 1; int b = 1;
            for (int i = 0; i < n-2; i++) 
            {
                b = a + b;
                a = b - a;
            }
            return b;
        }
    }
}
