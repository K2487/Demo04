using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        //fields


        //properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Phonenumber { get; set; }

        //default constructor
        public Person()
        {
        }

        // constructor takes person firstname and lastname as parameter
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        // methods
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        //return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address + " " + Age + " " + Phonenumber;
        }

    }
}
