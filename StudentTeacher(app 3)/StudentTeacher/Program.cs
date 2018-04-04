using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher dave = new Teacher("Dave", "Government");
            dave.Print();
            System.Console.ReadKey();

            System.Console.WriteLine();

            Teacher mark = new Teacher("Mark", "History");
            mark.Print();
            System.Console.ReadKey();

            System.Console.WriteLine();

            Student jenny = new Student("Jenny", dave);
            Student mike = new Student("Mike", dave);
            Student jerome = new Student("Jerome", mark);
            Student liz = new Student("Liz", mark);

            dave.givegrade(jenny, 95);
            jenny.Print();
            System.Console.ReadKey();

            System.Console.WriteLine();

            dave.givegrade(mike, 84);
            mike.Print();
            System.Console.ReadKey();

            System.Console.WriteLine();

            mark.givegrade(jerome, 97);
            jerome.Print();
            System.Console.ReadKey();

            System.Console.WriteLine();

            mark.givegrade(liz, 92);
            liz.Print();
            System.Console.ReadKey();








        }
    }
}
