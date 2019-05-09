using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    class Person
    {
        //attributes
        string fname;
        string lname;
        int age;

        //getters and setters
        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }

        //Constructor
        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }

    }
}
