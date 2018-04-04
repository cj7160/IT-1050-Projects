using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class Teacher
    {
        public string Name;
        public string Course;

        public Teacher(string firstname, string course)
        {
            this.Name = firstname;
            this.Course = course;
        }
        public void Print()
        {
            System.Console.WriteLine("Instructor Name: " + Name + ". ");
            System.Console.WriteLine("Instructor Course: " + Course + ". ");
        }
        public void givegrade(Student student, int grade)
        {
             student.SetGrade(grade);
        }
    }
}
