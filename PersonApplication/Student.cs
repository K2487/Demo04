using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Student : Person
    {
        public string StudentID { get; set; }

// default constructor
        public Student()
        {
        }

// parametric constuctor calls base class constructor with parameters
        public Student(string firstName, string lastName, string studentID) 
            : base(firstName,lastName)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to students!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID; 
        }

    }
}
