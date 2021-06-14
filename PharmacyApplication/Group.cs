using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    partial class Group
    {
        //Properties
        public string GroupName { get; set; }
        public int MaxStudent { get; set; }

        //Fields
        private static int _id = 0; //Unique ID
        public readonly int ID; //Unique ID
        public Student[] studentArray = new Student[0];

        //Constructor for unique ID
        public Group()
        {
            _id++;
            ID = _id;
        }

        //Constructor with 2 parametres
        public Group(string groupname, int maxstudent) : this()
        {
            GroupName = groupname;
            MaxStudent = maxstudent;
        }

    }
}
