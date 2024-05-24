using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student std1 = new student();
            std1.name = "ali";
            std1.family = "rezayi";
            std1.studentid = 1012762396;
            std1.city = "tehran";

            student std2 = new student();
            std2.name = "hasan";
            std2.family = "hasani";
            std2.studentid = 1012762634;
            std2.city = "mashhad";

            student std3 = new student();
            std3.name = "hesam";
            std3.family = "elyasi";
            std3.studentid = 1012762114;
            std3.city = "rasht";

            std1.show();
            std2.show(); 
            std3.show();
            Console.ReadLine();
        }

    }
}
