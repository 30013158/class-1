using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    class Program
    {
        static void Main(string[] args)
        {/*hard coded details*/
            Person Raj = new Person("Rajveer", "Kaur", 19);
            Console.WriteLine("Details of Person");
            Console.WriteLine($" Name: {Raj.Fname} {Raj.Lname} \nAge:{Raj.Age}");

            /*taking user input*/
            string fname, lname;
            int age;
            fname = Console.ReadLine();
            lname = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            Person p2 = new Person(fname, lname, age);

            
        }
    }
}
