using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Students
            Student stu = new Student("Ramiz", "Abbasov");
            Student stu1 = new Student("Krypton", "S3cd3d");

            //Groups
            Group group = new Group("P217", 16);
            //Adding students to the groups
            group.AddStudent(stu);
            group.AddStudent(stu1);
            group.AddStudent(stu2);
            Console.WriteLine("-----------------------------------------\n");
            //Showing students in the current group
            Console.WriteLine("-------Students in current group---------\n");
            group.StudentList();

            Console.Read();
        }
    }
}