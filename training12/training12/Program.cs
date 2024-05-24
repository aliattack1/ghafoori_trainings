using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fnums = new List<int>();
            for (int i = 2; i < 201; i++) 
            {
                if (fnums.Count == 0)
                {
                    fnums.Add(i);
                }
                else
                {
                    bool check = true;
                    foreach (int x in fnums)
                    {
                        if ((i/x)*x == i)
                        {
                            check = false;
                        }
                    }
                    if (check)
                    {
                        fnums.Add(i);
                    }
                }
            }
            foreach (int x in fnums)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
