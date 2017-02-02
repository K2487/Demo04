using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new person();

            //create one teacher from Teacher class
            Teacher teacher = new Teacher();
            teacher.Firstname = "Kirsi";
            teacher.Lastname = "Kernel";
            teacher.Age = 30;
            teacher.Address = "piippukatu 2";
            teacher.Phonenumber = "0202300303";
            teacher.Room = "D444";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Matti", "Mallikas", "H9900");
            student.Address = "Kirkkokatu 10";
            student.Age = 20;
            student.Phonenumber = "3030303";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

        }
    }
}
  