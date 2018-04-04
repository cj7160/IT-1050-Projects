using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class Student
    {
        private string Name;
        private int Grade;
        private Teacher Instructor;

        public Student(string name, Teacher instructor)
        {
            this.Name = name;
            this.Grade = 0;
            this.Instructor = instructor;
        }

        public void Print()
        {
            System.Console.WriteLine("Student Name: " + Name + ". ");
            System.Console.WriteLine("Grade: " + Grade + ". ");
            System.Console.WriteLine("Instructor: " + Instructor.Name + ". ");
        }
        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }
    }
}
