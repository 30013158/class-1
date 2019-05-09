using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Domestic" , "cow" );
            Console.WriteLine("The details of animal are:" + a1.Details());
            Console.ReadLine();
        }
        class Animal
        {//attributes
            string type;
            string name;
            int id;

            //getters and setters
            public string Type { get { return type; } set { type = value; } }
            public string Name { get { return name; } set { name = value; } }
            public int ID { get { return id; } set { id = value; } }

            //constructor
            public Animal(string _type, string _name)
            { Type = _type;
                Name = _name;
                ID = RandomId(); 
            }

            //method for generating random id number
           private int RandomId()
            { 
                Random rand = new Random();
                return rand.Next(1000, 9999);
            } 
            //method
            public string Details ()
            { return $"\nType: {Type} \nName: {Name}\nID: {ID}";  }
        }
    }
}
