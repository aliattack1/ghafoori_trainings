using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training7
{
    public class student
    {
        public string name;
        public string family;
        public int studentid;
        public string city;

        public void show()
        {
            Console.WriteLine(name+ " " +family+ " " + studentid.ToString() + " " + city);
        }
    }
}
