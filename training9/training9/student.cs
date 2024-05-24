using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training9
{
    public partial class student
    {
        private string name;
        private string family;
        private int nationalid;
        private string address;

        public string _name { get { return name; } set { name = value; } }
        public string _family { get { return family; } set { family = value; } }
        public int _nationalid { get { return nationalid; } set { nationalid = value; } }
        public string _address{ get { return address; } set { address = value; } }
    }
    public partial class student {
        public void show()
        {
            Console.WriteLine( _name + " " + _family + " " + _nationalid + " " + _address);
        }
    }
}
