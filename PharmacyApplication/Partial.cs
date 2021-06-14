using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    partial class Group 
    {
        //ToString() method that returns GroupName
        public override string ToString()
        {
            return $"GroupName: {GroupName} ID: {ID}";
        }

        //AddStudent method for adding students in array
        public void AddStudent(Student newStu)
        {

            if (studentArray.Length == MaxStudent)
	        {
                Console.WriteLine($"{GroupName} is full, You cannot add {newStu} to this group");
                return;
	        }

            Array.Resize(ref studentArray, studentArray.Length + 1);
            studentArray[studentArray.Length - 1] = newStu;

            Console.WriteLine($"{newStu.ToString()} Added");
        }

        //In order too see students in current group
        public void StudentList()
        {
            foreach (Student item in studentArray)
	        {
                Console.WriteLine(item);
	        }
        }

    }
}
