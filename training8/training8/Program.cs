using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student std1 = new student("ali", "abdol", 20, 19729821, "behrooz", 31231327, "tehran");
            student std2 = new student("reza", "hesami", 22, 16329364, "behrooz", 31233645, "tehran");
            student std3 = new student("mamad", "mamadi", 21, 19239555, "ali", 33231264, "tehran");
            student std4 = new student();
            std4._name = "saman";
            std4._family = "samani";
            std4._age = 25;
            std4._nationalid = 141786;
            std4._fathername = "pedarsaman";
            std4._studentid = 23997391;
            std4._city = "tehran";

            student std5 = new student();
            std5._name = "akbar";
            std5._family = "akbari";
            std5._age = 29;
            std5._nationalid = 14113;
            std5._fathername = "hanif";
            std5._studentid = 2394213;
            std5._city = "tehran";

            student std6 = new student();
            std6._name = "asghar";
            std6._family = "asghari";
            std6._age = 25;
            std6._nationalid = 14246;
            std6._fathername = "mani";
            std6._studentid = 23734391;
            std6._city = "barcelona";

            student std7 = new student();
            std7._name = "leyla";
            std7._family = "leylayi";
            std7._age = 24;
            std7._nationalid = 13426;
            std7._fathername = "sina";
            std7._studentid = 2444391;
            std7._city = "paris";

            student std8 = new student();
            std8._name = "pedram";
            std8._family = "pedrami";
            std8._age = 16;
            std8._nationalid = 1226;
            std8._fathername = "poya";
            std8._studentid = 23291;
            std8._city = "tehran";

            Console.ReadLine();
        }
    }
}
