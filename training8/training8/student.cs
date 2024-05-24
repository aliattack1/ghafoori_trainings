using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training8
{
    public class student
    {
        private string name;
        private string family;
        private int age;
        private int nationalid;
        private string fathername;
        private int studentid;
        private string city;

        public string _name { get { return name; } set { name = value; } }
        public string _family { get { return family; } set { family = value; } }
        public int _age { get { return age; } set
            {
                if (value < 20)
                {
                    age = 0;
                }
                else { 
                    age = value;
                }
            } 
        }
        public int _nationalid { get { return nationalid; } set { nationalid = value; } }
        public string _fathername { get { return fathername; } set {fathername = value; } }
        public int _studentid { get { return studentid; } set { studentid = value; } }
        public string _city { get { return city; } set { 
                if (value == "tehran")
                {
                    city = value;
                }
                else
                {
                    city = "0";
                }
                
            } }

        public student(string name, string family, int age, int nationalid, string fathername, int studentid, string city)
        {
            _name = name;
            _family = family;
            _age = age;
            _nationalid = nationalid;
            _fathername = fathername;
            _studentid = studentid;
            _city = city;
        }
        public student() { }
    }
}
